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

        public async Task UpdateRankingsAsync(DateTime targetDate)
        {
            if (targetDate.DayOfWeek != DayOfWeek.Monday)
                return;
            var thisMonday = targetDate.Date;
            var lastMonday = thisMonday.AddDays(-7);
            if (await _context.Rankings.AnyAsync(r => r.Date == thisMonday))
                return;
            var lastWeekMatches = await _context.Matches
                .Include(m => m.Draw)
                    .ThenInclude(d => d.Tournament)
                .Where(m => m.Date >= lastMonday && m.Date < thisMonday)
                .ToListAsync();
            var pointDistributions = await _context.PointDistributions
                .OrderBy(pd => pd.Category)
                .ThenBy(pd => pd.Round)
                .ToListAsync();
            var previousRankings = await _context.Rankings
                .Where(r => r.Date < thisMonday)
                .GroupBy(r => r.PlayerId)
                .Select(g => g.OrderByDescending(r => r.Date).First())
                .ToListAsync();
            var tournaments = lastWeekMatches
                .GroupBy(m => m.Draw.TournamentId)
                .ToDictionary(g => g.Key, g => g.ToList());
            var newRankings = new List<Ranking>();
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
                    Date = thisMonday
                });
            }
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