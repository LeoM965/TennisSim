using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TennisSim.Data;
using TennisSim.Models;

namespace TennisSim.Controllers
{
    public class ResultsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResultsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int id)
        {
            if (!HttpContext.Session.Keys.Contains("Username"))
                return RedirectToAction("EnterUsername", "GameStart");

            string? username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
                return RedirectToAction("EnterUsername", "GameStart");

            var user = await _context.UserNames
                .FirstOrDefaultAsync(u => u.Username == username);

            if (user == null)
                return NotFound("User not found");

            var tournament = await _context.Tournaments
                .Include(t => t.Draws.Where(d => d.UserId == user.Id))
                .ThenInclude(d => d.DrawMatches)
                .ThenInclude(dm => dm.Player1)
                .ThenInclude(p => p.Nationality)
                .Include(t => t.Draws)
                .ThenInclude(d => d.DrawMatches)
                .ThenInclude(dm => dm.Player2)
                .ThenInclude(p => p.Nationality)
                .Include(t => t.Draws)
                .ThenInclude(d => d.DrawMatches)
                .ThenInclude(dm => dm.Match)
                .Include(t => t.Draws)
                .ThenInclude(d => d.DrawMatches)
                .ThenInclude(dm => dm.Winner)
                .AsSplitQuery()
                .FirstOrDefaultAsync(t => t.Id == id);

            if (tournament == null)
            {
                return NotFound();
            }

            ViewData["CurrentDate"] = user.CurrentDate.ToString("d MMMM yyyy");

            return View(tournament);
        }

        public async Task<IActionResult> Details(int id)
        {
            if (!HttpContext.Session.Keys.Contains("Username"))
                return RedirectToAction("EnterUsername", "GameStart");

            string? username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
                return RedirectToAction("EnterUsername", "GameStart");

            var user = await _context.UserNames
                .FirstOrDefaultAsync(u => u.Username == username);

            if (user == null)
                return NotFound("User not found");

            var tournament = await _context.Tournaments
                .Include(t => t.Draws.Where(d => d.UserId == user.Id))
                .ThenInclude(d => d.DrawMatches)
                .ThenInclude(dm => dm.Player1)
                .ThenInclude(p => p.Nationality)
                .Include(t => t.Draws)
                .ThenInclude(d => d.DrawMatches)
                .ThenInclude(dm => dm.Player2)
                .ThenInclude(p => p.Nationality)
                .Include(t => t.Draws)
                .ThenInclude(d => d.DrawMatches)
                .ThenInclude(dm => dm.Match)
                .Include(t => t.Draws)
                .ThenInclude(d => d.DrawMatches)
                .ThenInclude(dm => dm.Winner)
                .Include(t => t.PointDistributions)
                .Include(t => t.Schedules)
                .AsSplitQuery()
                .FirstOrDefaultAsync(t => t.Id == id);

            if (tournament == null)
            {
                return NotFound();
            }

            if (tournament.Schedules != null)
            {
                tournament.Schedules = tournament.Schedules
                    .Where(s => s.Date <= user.CurrentDate)
                    .ToList();
            }

            ViewData["CurrentDate"] = user.CurrentDate.ToString("d MMMM yyyy");

            return View(tournament);
        }
    }
}