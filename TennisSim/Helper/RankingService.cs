using Microsoft.EntityFrameworkCore;
using TennisSim.Data;
using TennisSim.Models;
namespace TennisSim.Services
{
    public class RankingService
    {
        private const double DecayPercentage = 0.02;
        private readonly ApplicationDbContext _context;

        public RankingService(ApplicationDbContext context)
        {
            _context = context;
        }

        private static int CalculateTournamentPoints(
            List<Match> tournamentMatches,
            int playerId,
            List<PointDistribution> pointDistributions)
        {
            Match? finalMatch = tournamentMatches.FirstOrDefault(m => m.Round == "Final");
            if (finalMatch == null) return 0;
            Tournament tournament = finalMatch.Draw.Tournament;
            if (finalMatch.WinnerId == playerId)
            {
                return pointDistributions
                    .Where(pd => pd.Category == tournament.Category && pd.Round == "Winner")
                    .Select(pd => pd.Points)
                    .FirstOrDefault();
            }
            if ((finalMatch.Player1Id == playerId || finalMatch.Player2Id == playerId)
                && finalMatch.WinnerId != playerId)
            {
                return pointDistributions
                    .Where(pd => pd.Category == tournament.Category && pd.Round == "Final")
                    .Select(pd => pd.Points)
                    .FirstOrDefault();
            }
            Match? playerLastMatch = tournamentMatches
                .Where(m => (m.Player1Id == playerId || m.Player2Id == playerId))
                .OrderByDescending(m => m.Round)
                .FirstOrDefault();
            if (playerLastMatch != null)
            {
                return pointDistributions
                    .Where(pd => pd.Category == tournament.Category && pd.Round == playerLastMatch.Round)
                    .Select(pd => pd.Points)
                    .FirstOrDefault();
            }
            return 0;
        }

        public async Task UpdateRankingsAsync(DateTime targetDate, int userId)
        {
            if (!await _context.Rankings.AnyAsync(r => r.UserId == userId))
            {
                await CreateInitialRankingsAsync(targetDate, userId);
                return;
            }

            if (targetDate.DayOfWeek != DayOfWeek.Monday) return;

            DateTime thisMonday = targetDate.Date;
            DateTime lastMonday = thisMonday.AddDays(-7);

            if (await _context.Rankings.AnyAsync(r => r.Date == thisMonday && r.UserId == userId)) return;

            List<int> userDrawIds = await _context.Draws
                .Where(d => d.UserId == userId)
                .Select(d => d.Id)
                .ToListAsync();

            List<Match> lastWeekMatches = await _context.Matches
                .Include(m => m.Draw)
                    .ThenInclude(d => d.Tournament)
                .Where(m => m.Date >= lastMonday && m.Date < thisMonday && userDrawIds.Contains(m.DrawId))
                .ToListAsync();

            List<PointDistribution> pointDistributions = await _context.PointDistributions
                .OrderBy(pd => pd.Category)
                .ThenBy(pd => pd.Round)
                .ToListAsync();

            List<Ranking> newRankings = new List<Ranking>();

            DateTime latestPreviousDate = await _context.Rankings
                .Where(r => r.UserId == userId && r.Date < thisMonday)
                .MaxAsync(r => r.Date);

            List<Ranking> previousRankings = await _context.Rankings
                .Where(r => r.UserId == userId && r.Date == latestPreviousDate)
                .ToListAsync();

            List<int> rankedPlayerIds = previousRankings.Select(r => r.PlayerId).ToList();
            List<int> allPlayers = await _context.Players.Select(p => p.Id).ToListAsync();
            List<int> unrankedPlayerIds = allPlayers.Except(rankedPlayerIds).ToList();

            foreach (int playerId in unrankedPlayerIds)
            {
                previousRankings.Add(new Ranking
                {
                    PlayerId = playerId,
                    Points = 0,
                    Date = latestPreviousDate,
                    UserId = userId,
                    Rank = 0
                });
            }

            Dictionary<int, List<Match>> tournaments = lastWeekMatches
                .GroupBy(m => m.Draw.TournamentId)
                .ToDictionary(g => g.Key, g => g.ToList());

            foreach (Ranking prevRank in previousRankings)
            {
                int decayedPoints = (int)Math.Round(prevRank.Points * (1 - DecayPercentage));
                int maxTournamentPoints = 0;
                foreach (KeyValuePair<int, List<Match>> tournament in tournaments)
                {
                    int tournamentPoints = CalculateTournamentPoints(
                        tournament.Value,
                        prevRank.PlayerId,
                        pointDistributions
                    );
                    maxTournamentPoints = Math.Max(maxTournamentPoints, tournamentPoints);
                }
                newRankings.Add(new Ranking
                {
                    PlayerId = prevRank.PlayerId,
                    Points = decayedPoints + maxTournamentPoints,
                    Date = thisMonday,
                    UserId = userId
                });
            }

            List<Ranking> sortedRankings = newRankings
                .OrderByDescending(r => r.Points)
                .ToList();

            for (int i = 0; i < sortedRankings.Count; i++)
            {
                sortedRankings[i].Rank = i + 1;
            }

            await _context.Rankings.AddRangeAsync(sortedRankings);
            await _context.SaveChangesAsync();
        }

        private async Task CreateInitialRankingsAsync(DateTime targetDate, int userId)
        {
            DateTime rankingDate = targetDate.Date;
            while (rankingDate.DayOfWeek != DayOfWeek.Monday)
            {
                rankingDate = rankingDate.AddDays(1);
            }

            if (await _context.Rankings.AnyAsync(r => r.Date == rankingDate && r.UserId == userId))
                return;

            List<Ranking> newRankings = new List<Ranking>();
            DateTime latestSystemDate = DateTime.MinValue;

            try
            {
                latestSystemDate = await _context.Rankings
                    .Where(r => r.UserId == 0)
                    .MaxAsync(r => r.Date);
            }
            catch { }

            if (latestSystemDate != DateTime.MinValue)
            {
                List<Ranking> systemRankings = await _context.Rankings
                    .Where(r => r.UserId == 0 && r.Date == latestSystemDate)
                    .ToListAsync();

                if (systemRankings.Count > 0)
                {
                    foreach (Ranking systemRank in systemRankings)
                    {
                        newRankings.Add(new Ranking
                        {
                            PlayerId = systemRank.PlayerId,
                            Points = systemRank.Points,
                            Date = rankingDate,
                            UserId = userId,
                            Rank = systemRank.Rank
                        });
                    }

                    List<int> rankedPlayerIds = systemRankings.Select(r => r.PlayerId).ToList();
                    List<int> allPlayers = await _context.Players.Select(p => p.Id).ToListAsync();
                    List<int> unrankedPlayerIds = allPlayers.Except(rankedPlayerIds).ToList();

                    foreach (int playerId in unrankedPlayerIds)
                    {
                        newRankings.Add(new Ranking
                        {
                            PlayerId = playerId,
                            Points = 0,
                            Date = rankingDate,
                            UserId = userId,
                            Rank = 0
                        });
                    }
                }
                else
                {
                    await CreateDefaultRankingsAsync(rankingDate, userId, newRankings);
                }
            }
            else
            {
                await CreateDefaultRankingsAsync(rankingDate, userId, newRankings);
            }

            List<Ranking> sortedRankings = newRankings
                .OrderByDescending(r => r.Points)
                .ToList();

            for (int i = 0; i < sortedRankings.Count; i++)
            {
                sortedRankings[i].Rank = i + 1;
            }

            await _context.Rankings.AddRangeAsync(sortedRankings);
            await _context.SaveChangesAsync();

            if (targetDate < rankingDate)
            {
                foreach (var ranking in sortedRankings)
                {
                    _context.Rankings.Add(new Ranking
                    {
                        PlayerId = ranking.PlayerId,
                        Points = ranking.Points,
                        Date = targetDate,
                        UserId = userId,
                        Rank = ranking.Rank
                    });
                }
                await _context.SaveChangesAsync();
            }
        }

        private async Task CreateDefaultRankingsAsync(DateTime rankingDate, int userId, List<Ranking> newRankings)
        {
            List<Player> allPlayers = await _context.Players.ToListAsync();

            foreach (Player player in allPlayers)
            {
                newRankings.Add(new Ranking
                {
                    PlayerId = player.Id,
                    Points = 1000,
                    Date = rankingDate,
                    UserId = userId,
                    Rank = 0
                });
            }
        }
    }
}