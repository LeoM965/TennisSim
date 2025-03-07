using Microsoft.EntityFrameworkCore;
using TennisSim.Data;
using TennisSim.Models;

namespace TennisSim.Services
{
    public class MatchService : IMatchService
    {
        private readonly Random _random;
        private readonly ApplicationDbContext _context;

        public MatchService(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _random = new Random();
        }

        public async Task<MatchViewModel> GetMatchWithPlayersAndAttributes(int scheduleMatchId)
        {
            try
            {
                ScheduleMatch? scheduleMatch = await _context.ScheduleMatches
                    .Include(sm => sm.DrawMatch)
                        .ThenInclude(dm => dm.Player1)
                            .ThenInclude(p => p.Attributes)
                    .Include(sm => sm.DrawMatch)
                        .ThenInclude(dm => dm.Player2)
                            .ThenInclude(p => p.Attributes)
                    .Include(sm => sm.DrawMatch)
                        .ThenInclude(dm => dm.Match)
                    .Include(sm => sm.DrawMatch)
                        .ThenInclude(dm => dm.Draw)
                            .ThenInclude(d => d.Tournament)
                    .FirstOrDefaultAsync(sm => sm.Id == scheduleMatchId);

                if (scheduleMatch?.DrawMatch == null)
                    throw new InvalidOperationException($"ScheduleMatch with ID {scheduleMatchId} not found or has no DrawMatch.");

                DrawMatch drawMatch = scheduleMatch.DrawMatch;

                if (drawMatch.Player1 != null && drawMatch.Player1.Attributes == null)
                {
                    await _context.Entry(drawMatch.Player1)
                        .Collection(p => p.Attributes)
                        .LoadAsync();
                }

                if (drawMatch.Player2 != null && drawMatch.Player2.Attributes == null)
                {
                    await _context.Entry(drawMatch.Player2)
                        .Collection(p => p.Attributes)
                        .LoadAsync();
                }

                if (drawMatch.Player1?.Attributes == null || drawMatch.Player2?.Attributes == null)
                    throw new InvalidOperationException("Player attributes are missing.");

                Match match = drawMatch.Match ?? CreateNewMatch(scheduleMatch, drawMatch);

                return new MatchViewModel
                {
                    Match = match,
                    Player1Attributes = drawMatch.Player1.Attributes,
                    Player2Attributes = drawMatch.Player2.Attributes,
                    Tournament = drawMatch.Draw?.Tournament ?? new Tournament()
                };
            }
            catch (Exception ex)
            {
                throw new ServiceException("Error retrieving match data", ex);
            }
        }

        public async Task<MatchSimulationResult> SimulateMatch(int id)
        {
            try
            {
                MatchViewModel matchVM = await GetMatchWithPlayersAndAttributes(id);
                if (matchVM?.Player1Attributes == null || matchVM?.Player2Attributes == null)
                {
                    throw new InvalidOperationException("Player attributes are missing for simulation.");
                }

                MatchSimulation simulation = new MatchSimulation(_random);
                MatchSimulation.MatchResult result = simulation.SimulateMatch(matchVM.Player1Attributes, matchVM.Player2Attributes);

                ScheduleMatch scheduleMatch = await GetScheduleMatchWithDetails(id);
                if (scheduleMatch?.DrawMatch == null)
                {
                    throw new ArgumentException("Schedule match or draw match not found");
                }

                Player winner = result.WinnerIsPlayer1 ? matchVM.Match.Player1 : matchVM.Match.Player2;
                List<SetDetailResult> setDetails = ConvertToSetDetails(result.Sets);
                List<(int P1Score, int P2Score)> setsTuples = result.Sets.Select(s => (s.P1Score, s.P2Score)).ToList();
                string detailedScore = GenerateDetailedScore(result.Sets);

                await using Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction transaction = await _context.Database.BeginTransactionAsync();
                try
                {
                    await UpdateMatchResult(id, setsTuples, winner, scheduleMatch, detailedScore);
                    await AdvanceWinnerInTournament(scheduleMatch.DrawMatch, winner.Id);
                    await transaction.CommitAsync();
                }
                catch
                {
                    await transaction.RollbackAsync();
                    throw;
                }

                return new MatchSimulationResult
                {
                    Sets = setsTuples,
                    Winner = winner,
                    SetDetails = setDetails
                };
            }
            catch (Exception ex)
            {
                throw new ServiceException("Error during match simulation", ex);
            }
        }

        private async Task<ScheduleMatch> GetScheduleMatchWithDetails(int id)
        {
            ScheduleMatch? scheduleMatch = await _context.ScheduleMatches
                .Include(sm => sm.DrawMatch)
                    .ThenInclude(dm => dm.Draw)
                        .ThenInclude(d => d.DrawMatches)
                .Include(sm => sm.DrawMatch)
                    .ThenInclude(dm => dm.Match)
                .FirstOrDefaultAsync(sm => sm.Id == id);

            if (scheduleMatch == null)
                throw new InvalidOperationException($"ScheduleMatch with ID {id} not found.");

            return scheduleMatch;
        }

        private Match CreateNewMatch(ScheduleMatch scheduleMatch, DrawMatch drawMatch)
        {
            return new Match
            {
                Id = scheduleMatch.Id,
                Player1 = drawMatch.Player1,
                Player2 = drawMatch.Player2,
                Player1Id = drawMatch.Player1Id ?? 0,
                Player2Id = drawMatch.Player2Id ?? 0,
                Status = MatchStatus.Scheduled,
                Date = scheduleMatch.StartTime,
                Round = scheduleMatch.Round,
                DrawId = drawMatch.DrawId
            };
        }

        private List<SetDetailResult> ConvertToSetDetails(List<MatchSimulation.SetResult> sets)
        {
            return sets.Select((set, index) => new SetDetailResult
            {
                SetNumber = index + 1,
                Games = set.Games.Select((game, gameIndex) => new GameDetailResult
                {
                    GameNumber = gameIndex + 1,
                    Points = game.Points.Select(point => new PointDetailResult
                    {
                        P1ScoreDisplay = point.P1ScoreDisplay,
                        P2ScoreDisplay = point.P2ScoreDisplay,
                        WinnerIsPlayer1 = point.WinnerIsPlayer1
                    }).ToList(),
                    WinnerIsPlayer1 = game.WinnerIsPlayer1
                }).ToList(),
                P1Score = set.P1Score,
                P2Score = set.P2Score
            }).ToList();
        }

        private string GenerateDetailedScore(List<MatchSimulation.SetResult> sets)
        {
            return string.Join(", ", sets.Select(set =>
            {
                string gameScores = string.Join(" | ", set.Games.Select(game =>
                {
                    string pointScores = string.Join(" ", game.Points.Select(point =>
                        $"{point.P1ScoreDisplay}-{point.P2ScoreDisplay}"));
                    return $"[{pointScores}]";
                }));
                return $"{set.P1Score}-{set.P2Score} {gameScores}";
            }));
        }

        private async Task UpdateMatchResult(int scheduleMatchId, List<(int p1Score, int p2Score)> sets,
            Player winner, ScheduleMatch scheduleMatch, string detailedScore)
        {
            DrawMatch drawMatch = scheduleMatch.DrawMatch;
            if (drawMatch == null) return;

            drawMatch.WinnerId = winner.Id;
            drawMatch.Winner = winner;

            Match match = drawMatch.Match ?? new Match();
            await UpdateMatchDetails(match, drawMatch, scheduleMatch, winner, detailedScore);

            if (drawMatch.Match == null)
            {
                drawMatch.Match = match;
                _context.Matches.Add(match);
            }

            scheduleMatch.Status = MatchStatus.Completed;
            await _context.SaveChangesAsync();
        }

        private async Task UpdateMatchDetails(Match match, DrawMatch drawMatch,
            ScheduleMatch scheduleMatch, Player winner, string detailedScore)
        {
            if (drawMatch.Draw?.TournamentId > 0)
            {
                Tournament? tournament = await _context.Tournaments
                    .FirstOrDefaultAsync(t => t.Id == drawMatch.Draw.TournamentId);
                if (tournament != null)
                {
                    match.DrawId = drawMatch.Draw.TournamentId;
                }
            }

            match.Score = detailedScore;
            match.Status = MatchStatus.Completed;
            match.WinnerId = winner.Id;
            match.Player1Id = drawMatch.Player1Id ?? 0;
            match.Player2Id = drawMatch.Player2Id ?? 0;
            match.Round = scheduleMatch.Round;
            match.DrawId = drawMatch.DrawId;
            match.Date = scheduleMatch.StartTime;
        }

        private async Task AdvanceWinnerInTournament(DrawMatch currentMatch, int winnerId)
        {
            if (currentMatch.Draw == null) return;

            List<DrawMatch> allMatches = await _context.DrawMatches
                .Include(m => m.Player1)
                .Include(m => m.Player2)
                .Include(m => m.Winner)
                .Where(m => m.DrawId == currentMatch.DrawId)
                .OrderBy(m => m.Round)
                .ThenBy(m => m.MatchNumber)
                .ToListAsync();

            currentMatch.WinnerId = winnerId;
            Player? winner = await _context.Players.FindAsync(winnerId);
            currentMatch.Winner = winner;

            DrawMatch nextMatch = GetNextMatch(currentMatch, allMatches);
            if (nextMatch != null)
            {
                UpdateNextMatchPlayer(currentMatch, nextMatch);

                if (nextMatch.IsBye && nextMatch.Player1Id.HasValue && nextMatch.Player2Id.HasValue)
                {
                    nextMatch.WinnerId = nextMatch.Player1Id;
                    await AdvanceWinnerInTournament(nextMatch, nextMatch.Player1Id.Value);
                }
            }

            await _context.SaveChangesAsync();
        }

        private DrawMatch GetNextMatch(DrawMatch currentMatch, List<DrawMatch> allMatches)
        {
            return allMatches
               .Where(m => m.Round == currentMatch.Round + 1)
               .OrderBy(m => m.MatchNumber)
               .FirstOrDefault(m => m.MatchNumber == (currentMatch.MatchNumber + 1) / 2);
        }

        private void UpdateNextMatchPlayer(DrawMatch currentMatch, DrawMatch nextMatch)
        {
            if (currentMatch.MatchNumber % 2 == 1)
            {
                nextMatch.Player1Id = currentMatch.WinnerId;
                nextMatch.Player1 = currentMatch.Winner;
                nextMatch.Player1SeedNumber = GetWinnerSeedNumber(currentMatch);
            }
            else
            {
                nextMatch.Player2Id = currentMatch.WinnerId;
                nextMatch.Player2 = currentMatch.Winner;
                nextMatch.Player2SeedNumber = GetWinnerSeedNumber(currentMatch);
            }
        }

        private int? GetWinnerSeedNumber(DrawMatch match)
        {
            return match.WinnerId == match.Player1Id
                ? match.Player1SeedNumber
                : match.Player2SeedNumber;
        }
    }

    public class ServiceException : Exception
    {
        public ServiceException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
public class MatchSimulationResult
{
    public List<(int p1Score, int p2Score)> Sets { get; set; }
    public Player Winner { get; set; }
    public List<SetDetailResult> SetDetails { get; set; } = new();
}

public class SetDetailResult
{
    public int SetNumber { get; set; }
    public List<GameDetailResult> Games { get; set; } = new();
    public int P1Score { get; set; }
    public int P2Score { get; set; }
}

public class GameDetailResult
{
    public int GameNumber { get; set; }
    public List<PointDetailResult> Points { get; set; } = new();
    public bool WinnerIsPlayer1 { get; set; }
}

public class PointDetailResult
{
    public string P1ScoreDisplay { get; set; }
    public string P2ScoreDisplay { get; set; }
    public bool WinnerIsPlayer1 { get; set; }
}