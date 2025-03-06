using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TennisSim.Data;
using TennisSim.Models;
using TennisSim.Services;
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

        UserName? user = await _context.UserNames
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Username == username);

        if (user == null)
            return NotFound("User not found");

        await _rankingService.UpdateRankingsAsync(user.CurrentDate, user.Id);

        List<Ranking> userRankings = await _context.Rankings
            .Where(r => r.UserId == user.Id)
            .ToListAsync();

        DateTime latestRankingDate = userRankings
            .OrderByDescending(r => r.Date)
            .Select(r => r.Date)
            .FirstOrDefault();

        List<Player> players = await _context.Players
            .AsNoTracking()
            .Include(p => p.Nationality)
            .Include(p => p.Rankings.Where(r => r.UserId == user.Id))
            .ToListAsync();

        foreach (Player player in players)
        {
            Ranking? ranking = userRankings
                .Where(r => r.PlayerId == player.Id && r.Date == latestRankingDate)
                .FirstOrDefault();

            if (ranking != null)
            {
                player.Ranking = ranking.Rank;
            }
        }

        List<Player> sortedPlayers = players.OrderBy(p => p.Ranking == 0 ? int.MaxValue : p.Ranking).ToList();

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

        UserName? user = await _context.UserNames
            .FirstOrDefaultAsync(u => u.Username == username);

        if (user == null)
            return NotFound("User not found");

        await _rankingService.UpdateRankingsAsync(user.CurrentDate, user.Id);

        Player? player = await _context.Players
            .Include(p => p.Nationality)
            .Include(p => p.Attributes)
            .Include(p => p.Rankings.Where(r => r.UserId == user.Id))
            .FirstOrDefaultAsync(p => p.Id == id);

        if (player == null)
            return NotFound();

        List<int> userDrawIds = await _context.Draws
            .Where(d => d.UserId == user.Id)
            .Select(d => d.Id)
            .ToListAsync();

        DateTime currentDateOnly = user.CurrentDate.Date;

        List<Match> matches = await _context.Matches
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

        List<int> playerIds = matches.SelectMany(m => new[] { m.Player1Id, m.Player2Id })
            .Distinct()
            .ToList();

        List<Ranking> rankingsForPlayers = await _context.Rankings
            .Where(r => playerIds.Contains(r.PlayerId) && r.UserId == user.Id)
            .ToListAsync();

        foreach (Match match in matches)
        {
            if (match.Player1 != null)
            {
                List<Ranking> player1Rankings = rankingsForPlayers
                    .Where(r => r.PlayerId == match.Player1Id)
                    .ToList();

                match.Player1.Rankings = player1Rankings;

                Ranking? player1Ranking = player1Rankings
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
                List<Ranking> player2Rankings = rankingsForPlayers
                    .Where(r => r.PlayerId == match.Player2Id)
                    .ToList();

                match.Player2.Rankings = player2Rankings;

                Ranking? player2Ranking = player2Rankings
                    .Where(r => r.Date.Date <= match.Date.Date)
                    .OrderByDescending(r => r.Date)
                    .FirstOrDefault();

                if (player2Ranking != null)
                {
                    match.Player2.Ranking = player2Ranking.Rank;
                }
            }
        }

        int totalMatches = matches.Count;
        int totalWins = matches.Count(m => m.WinnerId == id);
        double winPercentage = totalMatches > 0 ? (double)totalWins / totalMatches * 100 : 0;

        PlayerDetailsViewModel viewModel = new PlayerDetailsViewModel
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