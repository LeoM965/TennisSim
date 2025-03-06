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

            bool isFirstWeek = !await _context.Rankings.AnyAsync(r => r.UserId == userId);

            if (isFirstWeek)
            {
                DateTime latestSystemDate = await _context.Rankings
                    .Where(r => r.UserId == 0)
                    .MaxAsync(r => r.Date);

                List<Ranking> systemRankings = await _context.Rankings
                    .Where(r => r.UserId == 0 && r.Date == latestSystemDate)
                    .ToListAsync();


                if (systemRankings.Count == 0)
                {
                    List<Player> allPlayers = await _context.Players.ToListAsync();

                    foreach (Player player in allPlayers)
                    {
                        int initialPoints = 1000;

                        newRankings.Add(new Ranking
                        {
                            PlayerId = player.Id,
                            Points = initialPoints,
                            Date = thisMonday,
                            UserId = userId,
                            Rank = 0
                        });
                    }
                }
                else
                {
                    foreach (Ranking systemRank in systemRankings)
                    {
                        newRankings.Add(new Ranking
                        {
                            PlayerId = systemRank.PlayerId,
                            Points = systemRank.Points,
                            Date = thisMonday,
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
                            Date = thisMonday,
                            UserId = userId,
                            Rank = 0
                        });
                    }
                }
            }
            else
            {
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
    }
}