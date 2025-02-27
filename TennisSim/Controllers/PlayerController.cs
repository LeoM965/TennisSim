using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TennisSim.Data;
using TennisSim.Models;
using TennisSim.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

public class PlayerController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly RankingService _rankingService;

    public PlayerController(ApplicationDbContext context, RankingService rankingService)
    {
        _context = context;
        _rankingService = rankingService;
    }

    public async Task<IActionResult> Index()
    {
        if (!HttpContext.Session.Keys.Contains("Username"))
            return RedirectToAction("EnterUsername", "GameStart");

        string? username = HttpContext.Session.GetString("Username");
        if (string.IsNullOrEmpty(username))
            return RedirectToAction("EnterUsername", "GameStart");

        var user = await _context.UserNames
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Username == username);

        if (user == null)
            return NotFound("User not found");

        await _rankingService.UpdateRankingsAsync(user.CurrentDate);

        var playersQuery = await _context.Players
            .AsNoTracking()
            .Include(p => p.Nationality)
            .Include(p => p.Rankings.OrderByDescending(r => r.Date))
            .Select(p => new
            {
                Player = p,
                LatestRanking = p.Rankings.OrderByDescending(r => r.Date).FirstOrDefault()
            })
            .OrderByDescending(x => x.LatestRanking != null ? x.LatestRanking.Points : 0)
            .ToListAsync();

        var sortedPlayers = playersQuery
            .Select((item, index) =>
            {
                item.Player.Ranking = index + 1;
                return item.Player;
            })
            .ToList();

        ViewData["CurrentDate"] = user.CurrentDate.ToString("d MMMM yyyy");

        return View(sortedPlayers);
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

        var player = await _context.Players
            .Include(p => p.Rankings.OrderByDescending(r => r.Date).Take(10))
            .Include(p => p.Nationality)
            .Include(p => p.Attributes)
            .FirstOrDefaultAsync(p => p.Id == id);

        if (player == null)
            return NotFound();

        var userDrawIds = await _context.Draws
            .Where(d => d.UserId == user.Id)
            .Select(d => d.Id)
            .ToListAsync();

        var currentDateOnly = user.CurrentDate.Date;

        var matches = await _context.Matches
            .Include(m => m.Draw)
                .ThenInclude(d => d.Tournament)
            .Include(m => m.Player1)
                .ThenInclude(p => p.Nationality)
            .Include(m => m.Player2)
                .ThenInclude(p => p.Nationality)
            .Where(m => (m.Player1Id == id || m.Player2Id == id) &&
                       userDrawIds.Contains(m.DrawId) &&
                       m.Date.Date <= currentDateOnly)
            .OrderByDescending(m => m.Date)
            .ToListAsync();

        var playerIds = matches.SelectMany(m => new[] { m.Player1Id, m.Player2Id })
            .Distinct()
            .ToList();

        var rankings = await _context.Rankings
            .Where(r => playerIds.Contains(r.PlayerId))
            .ToListAsync();

        foreach (var match in matches)
        {
            if (match.Player1 != null)
            {
                var player1Ranking = rankings
                    .Where(r => r.PlayerId == match.Player1Id && r.Date.Date <= match.Date.Date)
                    .OrderByDescending(r => r.Date)
                    .FirstOrDefault();
                match.Player1.Ranking = player1Ranking?.Points ?? 0;
            }

            if (match.Player2 != null)
            {
                var player2Ranking = rankings
                    .Where(r => r.PlayerId == match.Player2Id && r.Date.Date <= match.Date.Date)
                    .OrderByDescending(r => r.Date)
                    .FirstOrDefault();
                match.Player2.Ranking = player2Ranking?.Points ?? 0;
            }
        }

        var totalMatches = matches.Count;
        var totalWins = matches.Count(m => m.WinnerId == id);
        var winPercentage = totalMatches > 0 ? (double)totalWins / totalMatches * 100 : 0;

        var viewModel = new PlayerDetailsViewModel
        {
            Player = player,
            RecentMatches = matches,
            TotalMatches = totalMatches,
            TotalWins = totalWins,
            WinPercentage = winPercentage
        };

        ViewData["CurrentDate"] = user.CurrentDate.ToString("d MMMM yyyy");
        ViewData["Username"] = username;

        return View(viewModel);
    }

    public async Task<IActionResult> UpdateRankings()
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

        await _rankingService.UpdateRankingsAsync(user.CurrentDate);
        return RedirectToAction(nameof(Index));
    }
}