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

            UserName? user = _context.UserNames.FirstOrDefault(u => u.Username == username);
            if (user == null)
                return RedirectToAction("EnterUsername", "GameStart");

            List<Draw> draws = _context.Draws
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

            UserName? user = _context.UserNames.FirstOrDefault(u => u.Username == username);
            if (user == null)
                return NotFound("User not found");

            Draw? draw = _context.Draws
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

            UserName? user = _context.UserNames.FirstOrDefault(u => u.Username == username);
            if (user == null)
                return NotFound("User not found");

            Tournament? tournament = _context.Tournaments
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

            Draw? existingDraw = _context.Draws
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
                UserEntryList? userEntryList = tournament.UserEntryLists?
                    .FirstOrDefault(uel => uel.UserNameId == user.Id);

                List<EntryList> entryList;

                if (userEntryList != null && userEntryList.EntryList != null && userEntryList.EntryList.Any())
                {
                    entryList = userEntryList.EntryList.OrderBy(e => e.Rank).ToList();
                }
                else
                {
                    TempData["ErrorMessage"] = "You must view the entry list before generating the draw. This ensures that the correct players are included.";
                    return RedirectToAction("Details", "Tournament", new { id = tournamentId });
                }

                if (entryList.Count == 0)
                {
                    TempData["ErrorMessage"] = "Entry list is empty. Please select players for the draw first.";
                    return RedirectToAction("Details", "Tournament", new { id = tournamentId });
                }

                List<string> playerNames = entryList.Select(e => e.PlayerName).ToList();
                if (playerNames.Count != playerNames.Distinct().Count())
                {
                    TempData["ErrorMessage"] = "Entry list contains duplicate players. Please fix the entry list first.";
                    return RedirectToAction("Details", "Tournament", new { id = tournamentId });
                }

                Dictionary<string, Player> allPlayers = _context.Players
                    .Where(p => playerNames.Contains(p.Name))
                    .ToDictionary(p => p.Name, p => p);

                List<string> missingPlayers = playerNames.Except(allPlayers.Keys).ToList();
                if (missingPlayers.Any())
                {
                    string missingPlayersMessage = string.Join(", ", missingPlayers);
                    TempData["ErrorMessage"] = $"The following players were not found in the database: {missingPlayersMessage}";
                    return RedirectToAction("Details", "Tournament", new { id = tournamentId });
                }

                Draw draw = _drawService.CreateNewDraw(tournament, entryList, user.Id);
                return RedirectToAction("Draw", new { id = draw.Id });
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Failed to generate draw: {ex.Message}";
                return RedirectToAction("Details", "Tournament", new { id = tournamentId });
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