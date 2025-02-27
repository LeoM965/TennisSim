using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TennisSim.Data;
using TennisSim.Models;
using TennisSim.Services;

public class GameController : Controller
{
    private readonly IUserService _userService;
    private readonly ApplicationDbContext _context;

    public GameController(IUserService userService, ApplicationDbContext context)
    {
        _userService = userService;
        _context = context;
    }

    [HttpGet]
    public IActionResult Start(string username)
    {
        var user = _userService.GetUserByUsername(username);
        var model = new GameStartViewModel
        {
            Username = user.Username,
            CurrentDate = user.CurrentDate
        };
        return View(model);
    }

    [HttpGet]
    public IActionResult Load()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Load(string username)
    {
        var user = _userService.GetUserByUsername(username);

        if (user == null)
        {
            ModelState.AddModelError("", "User not found. Please check the username and try again.");
            return View();
        }

        HttpContext.Session.SetString("Username", username);

        return RedirectToAction("Start", "Game", new { username = username });
    }

    [HttpPost]
    public async Task<IActionResult> IncrementDay(string userId)
    {
        var user = await _context.UserNames
            .FirstOrDefaultAsync(u => u.Username == userId);

        if (user == null)
        {
            return Json(new { success = false, message = "User not found." });
        }

        var upcomingTournaments = await _context.Tournaments
            .Where(t => t.StartDate.Date > user.CurrentDate.Date &&
                       t.StartDate.Date <= user.CurrentDate.AddDays(2).Date)
            .ToListAsync();

        foreach (var tournament in upcomingTournaments)
        {
            var userEntryList = await _context.UserEntryLists
                .FirstOrDefaultAsync(uel => uel.UserNameId == user.Id &&
                                     uel.TournamentId == tournament.Id);

            if (userEntryList == null || !userEntryList.HasViewedDraw)
            {
                return Json(new
                {
                    success = false,
                    message = $"You must view both the entry list and draw for {tournament.Name} before proceeding."
                });
            }
        }

        var activeTournaments = await _context.Tournaments
            .Where(t => t.StartDate.Date <= user.CurrentDate.Date &&
                       t.EndDate.Date >= user.CurrentDate.Date)
            .ToListAsync();

        foreach (var tournament in activeTournaments)
        {
            var userDraw = await _context.Draws
                .FirstOrDefaultAsync(d => d.TournamentId == tournament.Id && d.UserId == user.Id);

            if (userDraw == null)
            {
                return Json(new
                {
                    success = false,
                    message = $"You must create a draw for {tournament.Name} before proceeding."
                });
            }

            var hasUserSchedule = await _context.Schedules
                .AnyAsync(s => s.Date.Date == user.CurrentDate.Date &&
                              s.DrawId == userDraw.Id);

            if (!hasUserSchedule)
            {
                return Json(new
                {
                    success = false,
                    message = $"You must create a schedule for {tournament.Name} before proceeding."
                });
            }
        }

        var currentUserSchedules = await _context.Schedules
            .Include(s => s.ScheduledMatches)
            .Include(s => s.Draw)
                .ThenInclude(d => d.Tournament)
            .Where(s => s.Date.Date == user.CurrentDate.Date &&
                       s.Draw.UserId == user.Id)
            .ToListAsync();

        var unplayedMatches = currentUserSchedules
            .SelectMany(s => s.ScheduledMatches)
            .Where(m => m.Status != MatchStatus.Completed &&
                       m.Status != MatchStatus.Cancelled &&
                       m.Status != MatchStatus.Walkover)
            .ToList();

        if (unplayedMatches.Any())
        {
            var tournamentGroups = unplayedMatches
                .GroupBy(m => m.Schedule.Draw.Tournament.Name)
                .Select(g => $"{g.Key}: {g.Count()} matches")
                .ToList();

            var matchDetails = string.Join(", ", tournamentGroups);
            return Json(new
            {
                success = false,
                message = $"You must complete all scheduled matches for {user.CurrentDate.ToString("MMMM dd, yyyy")} before proceeding. Remaining matches: {matchDetails}"
            });
        }

        user.CurrentDate = user.CurrentDate.AddDays(1);
        _context.Update(user);
        await _context.SaveChangesAsync();

        return Json(new
        {
            success = true,
            newDate = user.CurrentDate.ToString("MMMM dd, yyyy"),
            newDay = user.CurrentDate.ToString("dddd")
        });
    }
}