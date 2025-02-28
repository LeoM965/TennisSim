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
            var finalMatch = tournamentMatches.FirstOrDefault(m => m.Round == "Final");
            if (finalMatch == null) return 0;
            var tournament = finalMatch.Draw.Tournament;
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
            var playerLastMatch = tournamentMatches
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
            if (targetDate.DayOfWeek != DayOfWeek.Monday)
                return;
            var thisMonday = targetDate.Date;
            var lastMonday = thisMonday.AddDays(-7);

            // Check if rankings for this user on this date already exist
            if (await _context.Rankings.AnyAsync(r => r.Date == thisMonday && r.UserId == userId))
                return;

            // Get matches from user's tournaments only
            var userDrawIds = await _context.Draws
                .Where(d => d.UserId == userId)
                .Select(d => d.Id)
                .ToListAsync();

            var lastWeekMatches = await _context.Matches
                .Include(m => m.Draw)
                    .ThenInclude(d => d.Tournament)
                .Where(m => m.Date >= lastMonday && m.Date < thisMonday && userDrawIds.Contains(m.DrawId))
                .ToListAsync();

            var pointDistributions = await _context.PointDistributions
                .OrderBy(pd => pd.Category)
                .ThenBy(pd => pd.Round)
                .ToListAsync();

            var newRankings = new List<Ranking>();

            // Check if this is the first week of rankings for this user
            bool isFirstWeek = !await _context.Rankings.AnyAsync(r => r.UserId == userId);

            if (isFirstWeek)
            {
                // Get rankings from userId = 0 to use as initial rankings
                var systemRankings = await _context.Rankings
                    .Where(r => r.UserId == 0)
                    .GroupBy(r => r.PlayerId)
                    .Select(g => g.OrderByDescending(r => r.Date).First())
                    .ToListAsync();

                // Use system rankings as a starting point
                foreach (var systemRank in systemRankings)
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

                // Add any players who are not in system rankings
                var rankedPlayerIds = systemRankings.Select(r => r.PlayerId).ToList();
                var allPlayers = await _context.Players.Select(p => p.Id).ToListAsync();
                var unrankedPlayerIds = allPlayers.Except(rankedPlayerIds).ToList();

                foreach (var playerId in unrankedPlayerIds)
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
            else
            {
                // Get previous rankings for this user
                var previousRankings = await _context.Rankings
                    .Where(r => r.Date < thisMonday && r.UserId == userId)
                    .GroupBy(r => r.PlayerId)
                    .Select(g => g.OrderByDescending(r => r.Date).First())
                    .ToListAsync();

                // If no previous rankings exist for some players, we need to add them
                var allPlayers = await _context.Players.Select(p => p.Id).ToListAsync();
                var rankedPlayerIds = previousRankings.Select(r => r.PlayerId).ToList();
                var unrankedPlayerIds = allPlayers.Except(rankedPlayerIds).ToList();

                // Add initial rankings for unranked players
                foreach (var playerId in unrankedPlayerIds)
                {
                    previousRankings.Add(new Ranking
                    {
                        PlayerId = playerId,
                        Points = 0,
                        Date = lastMonday,
                        UserId = userId,
                        Rank = 0
                    });
                }

                var tournaments = lastWeekMatches
                    .GroupBy(m => m.Draw.TournamentId)
                    .ToDictionary(g => g.Key, g => g.ToList());

                foreach (var prevRank in previousRankings)
                {
                    var decayedPoints = (int)Math.Round(prevRank.Points * (1 - DecayPercentage));
                    var maxTournamentPoints = 0;
                    foreach (var tournament in tournaments)
                    {
                        var tournamentPoints = CalculateTournamentPoints(
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

            // Sort and assign ranks
            var sortedRankings = newRankings
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