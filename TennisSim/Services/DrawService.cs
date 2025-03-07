using Microsoft.EntityFrameworkCore;
using TennisSim.Data;
using TennisSim.Models;
using TennisSim.Utilities;

namespace TennisSim.Services
{
    public class DrawService : IDrawService
    {
        private readonly ApplicationDbContext _context;

        public DrawService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Draw CreateNewDraw(Tournament tournament, List<EntryList> entryList, int userId)
        {
            bool userExists = _context.UserNames.Any(u => u.Id == userId);
            if (!userExists)
            {
                throw new InvalidOperationException($"User with ID {userId} does not exist.");
            }

            int drawSize = DrawConstants.GetDrawSize(tournament.Category);
            int byeCount = DrawConstants.GetByeCount(tournament.Category);
            int seedCount = DrawConstants.GetSeedCount(tournament.Category);

            if (entryList == null || entryList.Count == 0)
            {
                throw new InvalidOperationException("Entry list is empty.");
            }

            Draw draw = new Draw
            {
                TournamentId = tournament.Id,
                UserId = userId,
                DrawSize = drawSize,
                ByeCount = byeCount,
                SeedCount = seedCount
            };

            _context.Draws.Add(draw);
            _context.SaveChanges();

            List<string> playerNames = entryList.Select(e => e.PlayerName).ToList();
            Dictionary<string, Player> allPlayers = _context.Players
                .Where(p => playerNames.Contains(p.Name))
                .ToDictionary(p => p.Name, p => p);

            List<DrawMatch> matches = GenerateDrawMatches(draw.Id, entryList, drawSize, byeCount, seedCount, allPlayers);

            foreach (DrawMatch match in matches)
            {
                _context.DrawMatches.Add(match);
            }

            _context.SaveChanges();

            ProcessByeMatches(matches);

            _context.SaveChanges();

            Draw? completeDrawWithMatches = _context.Draws
                .Include(d => d.DrawMatches)
                .FirstOrDefault(d => d.Id == draw.Id);

            return completeDrawWithMatches;
        }

        public void ProcessByeMatches(List<DrawMatch> matches)
        {
            List<DrawMatch> byeMatches = matches.Where(m => m.IsBye).ToList();
            foreach (DrawMatch byeMatch in byeMatches.Where(m => m.Player1Id.HasValue))
            {
                DrawMatch nextMatch = GetNextMatch(byeMatch, matches);
                if (nextMatch != null)
                {
                    if (byeMatch.MatchNumber % 2 != 0)
                    {
                        nextMatch.Player1Id = byeMatch.Player1Id;
                        nextMatch.Player1SeedNumber = byeMatch.Player1SeedNumber;
                    }
                    else
                    {
                        nextMatch.Player2Id = byeMatch.Player1Id;
                        nextMatch.Player2SeedNumber = byeMatch.Player1SeedNumber;
                    }
                }
            }
        }

        public DrawMatch GetNextMatch(DrawMatch currentMatch, List<DrawMatch> allMatches)
        {
            int nextRoundMatchNumber = (currentMatch.MatchNumber + 1) / 2;
            DrawMatch? nextMatch = allMatches.FirstOrDefault(m =>
                m.Round == currentMatch.Round + 1 &&
                m.MatchNumber == nextRoundMatchNumber);

            if (nextMatch == null)
            {
                throw new InvalidOperationException($"No next match found for match {currentMatch.MatchNumber} in round {currentMatch.Round}");
            }

            return nextMatch;
        }

        public List<DrawMatch> GenerateDrawMatches(int drawId, List<EntryList> entryList, int drawSize, int byeCount,
            int seedCount, Dictionary<string, Player> preloadedPlayers)
        {
            List<DrawMatch> matches = new List<DrawMatch>();
            int roundCount = (int)Math.Log2(drawSize);
            int firstRoundMatchCount = drawSize / 2;

            for (int round = 1; round <= roundCount; round++)
            {
                int matchesInRound = drawSize / (int)Math.Pow(2, round);
                for (int i = 1; i <= matchesInRound; i++)
                {
                    DrawMatch drawMatch = new DrawMatch
                    {
                        DrawId = drawId,
                        Round = round,
                        MatchNumber = i
                    };
                    matches.Add(drawMatch);
                }
            }

            List<DrawMatch> firstRoundMatches = matches.Where(m => m.Round == 1).ToList();

            int seedsCount = Math.Min(seedCount, entryList.Count);

            List<EntryList> seeds = entryList.Take(seedsCount).ToList();
            for (int i = 0; i < seeds.Count; i++)
            {
                int position = DrawConstants.GetSeedPosition(i + 1, firstRoundMatchCount);

                if (position >= 0 && position < firstRoundMatches.Count)
                {
                    DrawMatch match = firstRoundMatches[position];

                    if (preloadedPlayers.TryGetValue(seeds[i].PlayerName, out Player? player))
                    {
                        match.Player1Id = player.Id;
                        match.Player1SeedNumber = i + 1;

                        if (i < byeCount)
                        {
                            match.IsBye = true;
                            match.WinnerId = player.Id;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Seed player not found: {seeds[i].PlayerName}");
                    }
                }
            }

            List<EntryList> remainingEntries = entryList.Skip(seedsCount).ToList();
            List<Player> remainingPlayers = new List<Player>();

            foreach (EntryList entry in remainingEntries)
            {
                if (preloadedPlayers.TryGetValue(entry.PlayerName, out Player? player))
                {
                    remainingPlayers.Add(player);
                }
            }

            remainingPlayers = remainingPlayers.OrderBy(x => Guid.NewGuid()).ToList();

            foreach (DrawMatch match in firstRoundMatches.Where(m => m.Player1Id == null))
            {
                if (remainingPlayers.Count == 0) break;

                Player player = remainingPlayers[0];
                match.Player1Id = player.Id;
                remainingPlayers.RemoveAt(0);
            }

            foreach (DrawMatch match in firstRoundMatches.Where(m => !m.IsBye && m.Player2Id == null))
            {
                if (remainingPlayers.Count == 0) break;

                Player player = remainingPlayers[0];
                match.Player2Id = player.Id;
                remainingPlayers.RemoveAt(0);
            }

            return matches;
        }

        public void UpdateUserEntryListsViewStatus(int tournamentId)
        {
            IQueryable<UserEntryList> userEntryLists = _context.UserEntryLists
                .Where(uel => uel.TournamentId == tournamentId && !uel.HasViewedDraw);

            foreach (UserEntryList userEntry in userEntryLists)
            {
                userEntry.HasViewedDraw = true;
            }
            _context.SaveChanges();
        }
    }
}