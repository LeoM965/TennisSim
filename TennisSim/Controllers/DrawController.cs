using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TennisSim.Data;
using TennisSim.Models;
using TennisSim.Services;

namespace TennisSim.Controllers
{
    public class DrawController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IDrawService _drawService;

        public DrawController(ApplicationDbContext context, IDrawService drawService)
        {
            _context = context;
            _drawService = drawService;
        }

        public IActionResult Index()
        {
            if (!IsUserAuthenticated(out string username))
                return RedirectToAction("EnterUsername", "GameStart");

            var user = _context.UserNames.FirstOrDefault(u => u.Username == username);
            if (user == null)
                return RedirectToAction("EnterUsername", "GameStart");

            var draws = _context.Draws
                .Include(d => d.Tournament)
                .Where(d => d.Tournament != null && d.UserId == user.Id)
                .OrderByDescending(d => d.Tournament.StartDate)
                .ToList();

            return View(draws);
        }

        public IActionResult Draw(int id)
        {
            if (!IsUserAuthenticated(out string username))
                return RedirectToAction("EnterUsername", "GameStart");

            var user = _context.UserNames.FirstOrDefault(u => u.Username == username);
            if (user == null)
                return NotFound("User not found");

            var draw = _context.Draws
                .Include(d => d.Tournament)
                .Include(d => d.DrawMatches.OrderBy(m => m.Round).ThenBy(m => m.MatchNumber))
                    .ThenInclude(m => m.Player1)
                .Include(d => d.DrawMatches.OrderBy(m => m.Round).ThenBy(m => m.MatchNumber))
                    .ThenInclude(m => m.Player2)
                .Include(d => d.DrawMatches.OrderBy(m => m.Round).ThenBy(m => m.MatchNumber))
                    .ThenInclude(m => m.Winner)
                .FirstOrDefault(d => d.Id == id && d.UserId == user.Id);

            if (draw == null)
                return NotFound("Draw not found for this user");

            if (draw.Tournament != null && user.CurrentDate < draw.Tournament.StartDate.AddDays(-2))
            {
                ViewData["TournamentName"] = draw.Tournament.Name;
                ViewData["DrawMessage"] = "The draw will be available closer to the tournament date.";
                return View();
            }

            return View(draw);
        }

        public IActionResult GenerateDraw(int tournamentId)
        {
            if (!IsUserAuthenticated(out string username))
                return RedirectToAction("EnterUsername", "GameStart");

            var user = _context.UserNames.FirstOrDefault(u => u.Username == username);
            if (user == null)
                return NotFound("User not found");

            var tournament = _context.Tournaments
                .Include(t => t.UserEntryLists)
                    .ThenInclude(uel => uel.EntryList)
                .FirstOrDefault(t => t.Id == tournamentId);

            if (tournament == null)
                return NotFound("Tournament not found");

            if (user.CurrentDate < tournament.StartDate.AddDays(-2))
            {
                ViewData["TournamentName"] = tournament.Name;
                ViewData["DrawMessage"] = "The draw will be available closer to the tournament date.";
                return View("Draw");
            }

            var existingDraw = _context.Draws
                .Include(d => d.DrawMatches)
                    .ThenInclude(m => m.Player1)
                .Include(d => d.DrawMatches)
                    .ThenInclude(m => m.Player2)
                .Include(d => d.DrawMatches)
                    .ThenInclude(m => m.Winner)
                .FirstOrDefault(d => d.TournamentId == tournamentId && d.UserId == user.Id);

            _drawService.UpdateUserEntryListsViewStatus(tournamentId);

            if (existingDraw != null)
                return View("Draw", existingDraw);

            try
            {
                var userEntryList = tournament.UserEntryLists?
                    .FirstOrDefault(uel => uel.UserNameId == user.Id);

                List<EntryList> entryList;

                if (userEntryList != null && userEntryList.EntryList != null && userEntryList.EntryList.Any())
                {
                    entryList = userEntryList.EntryList.OrderBy(e => e.Rank).ToList();
                }
                else
                {
                    entryList = tournament.UserEntryLists?
                        .Where(uel => uel.EntryList != null)
                        .SelectMany(uel => uel.EntryList)
                        .OrderBy(e => e.Rank)
                        .ToList() ?? new List<EntryList>();
                }

                if (entryList.Count == 0)
                {
                    ViewData["ErrorMessage"] = "No entry list found for this tournament";
                    return View("Error");
                }

                var playerNames = entryList.Select(e => e.PlayerName).ToList();
                var allPlayers = _context.Players
                    .Where(p => playerNames.Contains(p.Name))
                    .ToDictionary(p => p.Name, p => p);

                var missingPlayers = playerNames.Except(allPlayers.Keys).ToList();
                if (missingPlayers.Any())
                {
                    var missingPlayersMessage = string.Join(", ", missingPlayers);
                    ViewData["ErrorMessage"] = $"The following players were not found in the database: {missingPlayersMessage}";
                    return View("Error");
                }

                var draw = _drawService.CreateNewDraw(tournament, entryList, user.Id);
                return RedirectToAction("Draw", new { id = draw.Id });
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = $"Failed to generate draw: {ex.Message}";
                return View("Error");
            }
        }

        private bool IsUserAuthenticated(out string username)
        {
            username = string.Empty;

            if (!HttpContext.Session.Keys.Contains("Username"))
                return false;

            username = HttpContext.Session.GetString("Username") ?? string.Empty;
            return !string.IsNullOrEmpty(username);
        }
    }
}