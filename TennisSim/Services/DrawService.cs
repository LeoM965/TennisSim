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
            // Verifică dacă utilizatorul există
            var userExists = _context.UserNames.Any(u => u.Id == userId);
            if (!userExists)
            {
                throw new InvalidOperationException($"User with ID {userId} does not exist.");
            }

            // Obține dimensiunile necesare pentru draw
            var drawSize = DrawConstants.GetDrawSize(tournament.Category);
            var byeCount = DrawConstants.GetByeCount(tournament.Category);
            var seedCount = DrawConstants.GetSeedCount(tournament.Category);

            // Verifică dacă avem suficienți jucători în lista de intrare
            if (entryList == null || entryList.Count == 0)
            {
                throw new InvalidOperationException("Entry list is empty.");
            }

            // Creează un nou draw
            var draw = new Draw
            {
                TournamentId = tournament.Id,
                UserId = userId
            };

            // Adaugă draw-ul în context și salvează pentru a obține ID-ul
            _context.Draws.Add(draw);
            _context.SaveChanges();

            // Pre-încarcă toți jucătorii din entry-list pentru a evita căutări multiple
            var playerNames = entryList.Select(e => e.PlayerName).ToList();
            var allPlayers = _context.Players
                .Where(p => playerNames.Contains(p.Name))
                .ToDictionary(p => p.Name, p => p);

            // Generează meciurile pentru draw
            var matches = GenerateDrawMatches(draw.Id, entryList, drawSize, byeCount, seedCount, allPlayers);

            // Adaugă explicit meciurile la context
            foreach (var match in matches)
            {
                _context.DrawMatches.Add(match);
            }

            // Salvează meciurile în baza de date
            _context.SaveChanges();

            // Procesează meciurile de tip "bye"
            ProcessByeMatches(matches);

            // Salvează actualizările pentru meciurile "bye"
            _context.SaveChanges();

            // Încarcă Draw-ul complet cu toate meciurile pentru a-l returna
            var completeDrawWithMatches = _context.Draws
                .Include(d => d.DrawMatches)
                .FirstOrDefault(d => d.Id == draw.Id);

            return completeDrawWithMatches;
        }

        public void ProcessByeMatches(List<DrawMatch> matches)
        {
            var byeMatches = matches.Where(m => m.IsBye).ToList();
            foreach (var byeMatch in byeMatches.Where(m => m.Player1Id.HasValue))
            {
                var nextMatch = GetNextMatch(byeMatch, matches);
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
            var nextRoundMatchNumber = (currentMatch.MatchNumber + 1) / 2;
            var nextMatch = allMatches.FirstOrDefault(m =>
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
            var matches = new List<DrawMatch>();
            var roundCount = (int)Math.Log2(drawSize);
            var firstRoundMatchCount = drawSize / 2;

            // Creează meciurile pentru fiecare rundă
            for (int round = 1; round <= roundCount; round++)
            {
                var matchesInRound = drawSize / (int)Math.Pow(2, round);
                for (int i = 1; i <= matchesInRound; i++)
                {
                    var drawMatch = new DrawMatch
                    {
                        DrawId = drawId,
                        Round = round,
                        MatchNumber = i
                    };
                    matches.Add(drawMatch);
                }
            }

            // Obține meciurile din prima rundă
            var firstRoundMatches = matches.Where(m => m.Round == 1).ToList();

            // Verifică dacă avem suficienți seeds în lista de intrare
            var seedsCount = Math.Min(seedCount, entryList.Count);

            // Asignează jucătorii seed-uiți la pozițiile corespunzătoare
            var seeds = entryList.Take(seedsCount).ToList();
            for (int i = 0; i < seeds.Count; i++)
            {
                var position = DrawConstants.GetSeedPosition(i + 1, firstRoundMatchCount);

                // Verifică dacă poziția este validă
                if (position >= 0 && position < firstRoundMatches.Count)
                {
                    var match = firstRoundMatches[position];

                    // Caută jucătorul în dicționar pentru a evita căutări multiple în baza de date
                    if (preloadedPlayers.TryGetValue(seeds[i].PlayerName, out var player))
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
                        // Log sau gestionare pentru cazul în care jucătorul nu este găsit
                        Console.WriteLine($"Seed player not found: {seeds[i].PlayerName}");
                    }
                }
            }

            // Asignează jucătorii rămași la meciurile din prima rundă
            var remainingEntries = entryList.Skip(seedsCount).ToList();
            var remainingPlayers = new List<Player>();

            // Construiește lista de jucători rămași folosind dicționarul preîncărcat
            foreach (var entry in remainingEntries)
            {
                if (preloadedPlayers.TryGetValue(entry.PlayerName, out var player))
                {
                    remainingPlayers.Add(player);
                }
            }

            // Amestecă jucătorii rămași
            remainingPlayers = remainingPlayers.OrderBy(x => Guid.NewGuid()).ToList();

            // Asignează jucătorii rămași ca Player1 pentru meciurile fără Player1
            foreach (var match in firstRoundMatches.Where(m => m.Player1Id == null))
            {
                if (remainingPlayers.Count == 0) break;

                var player = remainingPlayers[0];
                match.Player1Id = player.Id;
                remainingPlayers.RemoveAt(0);
            }

            // Asignează jucătorii rămași ca Player2 pentru meciurile care nu sunt bye și nu au Player2
            foreach (var match in firstRoundMatches.Where(m => !m.IsBye && m.Player2Id == null))
            {
                if (remainingPlayers.Count == 0) break;

                var player = remainingPlayers[0];
                match.Player2Id = player.Id;
                remainingPlayers.RemoveAt(0);
            }

            return matches;
        }

        public void UpdateUserEntryListsViewStatus(int tournamentId)
        {
            var userEntryLists = _context.UserEntryLists
                .Where(uel => uel.TournamentId == tournamentId && !uel.HasViewedDraw);

            foreach (var userEntry in userEntryLists)
            {
                userEntry.HasViewedDraw = true;
            }
            _context.SaveChanges();
        }
    }
}