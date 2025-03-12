using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

            var userWithDraws = _context.UserNames
                .Where(u => u.Username == username)
                .Select(u => new
                {
                    User = u,
                    Draws = _context.Draws
                        .Include(d => d.Tournament)
                        .Where(d => d.Tournament != null && d.UserId == u.Id)
                        .OrderByDescending(d => d.Tournament.StartDate)
                        .ToList()
                })
                .FirstOrDefault();

            if (userWithDraws == null)
                return RedirectToAction("EnterUsername", "GameStart");

            return View(userWithDraws.Draws);
        }

        public IActionResult Draw(int id)
        {
            if (!IsUserAuthenticated(out string username))
                return RedirectToAction("EnterUsername", "GameStart");

            var result = _context.UserNames
                .Where(u => u.Username == username)
                .Select(u => new
                {
                    User = u,
                    Draw = _context.Draws
                        .Include(d => d.Tournament)
                        .Include(d => d.DrawMatches.OrderBy(m => m.Round).ThenBy(m => m.MatchNumber))
                            .ThenInclude(m => m.Player1)
                        .Include(d => d.DrawMatches.OrderBy(m => m.Round).ThenBy(m => m.MatchNumber))
                            .ThenInclude(m => m.Player2)
                        .Include(d => d.DrawMatches.OrderBy(m => m.Round).ThenBy(m => m.MatchNumber))
                            .ThenInclude(m => m.Winner)
                        .FirstOrDefault(d => d.Id == id && d.UserId == u.Id)
                })
                .FirstOrDefault();

            if (result == null || result.User == null)
                return NotFound("User not found");

            if (result.Draw == null)
                return NotFound("Draw not found for this user");

            if (result.Draw.Tournament != null && result.User.CurrentDate < result.Draw.Tournament.StartDate.AddDays(-2))
            {
                ViewData["TournamentName"] = result.Draw.Tournament.Name;
                ViewData["DrawMessage"] = "The draw will be available closer to the tournament date.";
                return View();
            }

            return View(result.Draw);
        }

        public IActionResult GenerateDraw(int tournamentId)
        {
            if (!IsUserAuthenticated(out string username))
                return RedirectToAction("EnterUsername", "GameStart");

            var data = _context.UserNames
                .Where(u => u.Username == username)
                .Select(u => new
                {
                    User = u,
                    Tournament = _context.Tournaments
                        .Include(t => t.UserEntryLists)
                            .ThenInclude(uel => uel.EntryList)
                        .FirstOrDefault(t => t.Id == tournamentId),
                    ExistingDraw = _context.Draws
                        .Include(d => d.DrawMatches)
                            .ThenInclude(m => m.Player1)
                        .Include(d => d.DrawMatches)
                            .ThenInclude(m => m.Player2)
                        .Include(d => d.DrawMatches)
                            .ThenInclude(m => m.Winner)
                        .FirstOrDefault(d => d.TournamentId == tournamentId && d.UserId == u.Id)
                })
                .FirstOrDefault();

            if (data == null || data.User == null)
                return NotFound("User not found");

            if (data.Tournament == null)
                return NotFound("Tournament not found");

            if (data.User.CurrentDate < data.Tournament.StartDate.AddDays(-2))
            {
                ViewData["TournamentName"] = data.Tournament.Name;
                ViewData["DrawMessage"] = "The draw will be available closer to the tournament date.";
                return View("Draw");
            }

            _drawService.UpdateUserEntryListsViewStatus(tournamentId);

            if (data.ExistingDraw != null)
                return View("Draw", data.ExistingDraw);

            try
            {
                UserEntryList userEntryList = data.Tournament.UserEntryLists?
                    .FirstOrDefault(uel => uel.UserNameId == data.User.Id);

                if (userEntryList == null || userEntryList.EntryList == null || !userEntryList.EntryList.Any())
                {
                    TempData["ErrorMessage"] = "You must view the entry list before generating the draw. This ensures that the correct players are included.";
                    return RedirectToAction("Details", "Tournament", new { id = tournamentId });
                }

                List<EntryList> entryList = userEntryList.EntryList.OrderBy(e => e.Rank).ToList();

                if (entryList.Count == 0)
                {
                    TempData["ErrorMessage"] = "Entry list is empty. Please select players for the draw first.";
                    return RedirectToAction("Details", "Tournament", new { id = tournamentId });
                }

                List<string> playerNames = entryList.Select(e => e.PlayerName).ToList();
                int distinctCount = new HashSet<string>(playerNames).Count;
                if (playerNames.Count != distinctCount)
                {
                    TempData["ErrorMessage"] = "Entry list contains duplicate players. Please fix the entry list first.";
                    return RedirectToAction("Details", "Tournament", new { id = tournamentId });
                }

                Dictionary<string, Player> allPlayers = _context.Players
                    .Where(p => playerNames.Contains(p.Name))
                    .ToDictionary(p => p.Name);

                List<string> missingPlayers = playerNames.Where(p => !allPlayers.ContainsKey(p)).ToList();
                if (missingPlayers.Any())
                {
                    string missingPlayersMessage = string.Join(", ", missingPlayers);
                    TempData["ErrorMessage"] = $"The following players were not found in the database: {missingPlayersMessage}";
                    return RedirectToAction("Details", "Tournament", new { id = tournamentId });
                }

                Draw draw = _drawService.CreateNewDraw(data.Tournament, entryList, data.User.Id);
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
            username = HttpContext.Session.GetString("Username") ?? string.Empty;
            return !string.IsNullOrEmpty(username);
        }
    }
}