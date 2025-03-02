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

        await _rankingService.UpdateRankingsAsync(user.CurrentDate, user.Id);

        var userRankings = await _context.Rankings
            .Where(r => r.UserId == user.Id)
            .ToListAsync();

        var latestRankingDate = userRankings
            .OrderByDescending(r => r.Date)
            .Select(r => r.Date)
            .FirstOrDefault();

        var players = await _context.Players
            .AsNoTracking()
            .Include(p => p.Nationality)
            .Include(p => p.Rankings.Where(r => r.UserId == user.Id))
            .ToListAsync();

        foreach (var player in players)
        {
            var ranking = userRankings
                .Where(r => r.PlayerId == player.Id && r.Date == latestRankingDate)
                .FirstOrDefault();

            if (ranking != null)
            {
                player.Ranking = ranking.Rank;
            }
        }

        var sortedPlayers = players.OrderBy(p => p.Ranking == 0 ? int.MaxValue : p.Ranking).ToList();

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

        await _rankingService.UpdateRankingsAsync(user.CurrentDate, user.Id);

        var player = await _context.Players
            .Include(p => p.Nationality)
            .Include(p => p.Attributes)
            .Include(p => p.Rankings.Where(r => r.UserId == user.Id))
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

        var rankingsForPlayers = await _context.Rankings
            .Where(r => playerIds.Contains(r.PlayerId) && r.UserId == user.Id)
            .ToListAsync();

        foreach (var match in matches)
        {
            if (match.Player1 != null)
            {
                var player1Rankings = rankingsForPlayers
                    .Where(r => r.PlayerId == match.Player1Id)
                    .ToList();

                match.Player1.Rankings = player1Rankings;

                var player1Ranking = player1Rankings
                    .Where(r => r.Date.Date <= match.Date.Date)
                    .OrderByDescending(r => r.Date)
                    .FirstOrDefault();

                if (player1Ranking != null)
                {
                    match.Player1.Ranking = player1Ranking.Rank;
                }
            }

            if (match.Player2 != null)
            {
                var player2Rankings = rankingsForPlayers
                    .Where(r => r.PlayerId == match.Player2Id)
                    .ToList();

                match.Player2.Rankings = player2Rankings;

                var player2Ranking = player2Rankings
                    .Where(r => r.Date.Date <= match.Date.Date)
                    .OrderByDescending(r => r.Date)
                    .FirstOrDefault();

                if (player2Ranking != null)
                {
                    match.Player2.Ranking = player2Ranking.Rank;
                }
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
}