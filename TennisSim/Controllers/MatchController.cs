using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TennisSim.Data;
using TennisSim.Models;
using TennisSim.Services;

namespace TennisSim.Controllers
{
    public class MatchController : Controller
    {
        private readonly IMatchService _matchService;
        private readonly ILogger<MatchController> _logger;
        private readonly ApplicationDbContext _context;

        public MatchController(IMatchService matchService, ILogger<MatchController> logger, ApplicationDbContext context)
        {
            _matchService = matchService;
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> MatchDetails(int drawMatchId)
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

            var drawMatch = await _context.DrawMatches
                .Include(d => d.Player1)
                    .ThenInclude(p => p.Nationality)
                .Include(d => d.Player2)
                    .ThenInclude(p => p.Nationality)
                .Include(d => d.Draw.Tournament)
                .FirstOrDefaultAsync(d => d.Id == drawMatchId);

            if (drawMatch == null)
            {
                return NotFound();
            }

            var player1Id = drawMatch.Player1Id;
            var player2Id = drawMatch.Player2Id;

            var headToHeadMatches = await _context.Matches
                .Where(m =>
                    ((m.Player1Id == player1Id && m.Player2Id == player2Id) ||
                    (m.Player1Id == player2Id && m.Player2Id == player1Id)) &&
                    m.Draw.UserId == user.Id) 
                .OrderByDescending(m => m.Date)
                .Include(m => m.Player1)
                .Include(m => m.Player2)
                .Include(m => m.Winner)
                .Include(m => m.Draw)
                    .ThenInclude(d => d.Tournament)
                .AsSplitQuery()  
                .ToListAsync();

            var viewModel = new MatchDetailsViewModel
            {
                HeadToHeadMatches = headToHeadMatches,
                Player1Id = drawMatch.Player1.Id,
                Player2Id = drawMatch.Player2.Id,
                Player1Name = drawMatch.Player1.Name,
                Player2Name = drawMatch.Player2.Name,
                Player1Nationality = drawMatch.Player1.Nationality,
                Player2Nationality = drawMatch.Player2.Nationality,
                Player1Wins = headToHeadMatches.Count(m => m.WinnerId == player1Id),
                Player2Wins = headToHeadMatches.Count(m => m.WinnerId == player2Id),
                RoundStats = headToHeadMatches
                    .GroupBy(m => m.Round)
                    .ToDictionary(g => g.Key, g => g.Count()),
                TournamentName = drawMatch.Draw.Tournament.Name,
            };

            ViewData["CurrentDate"] = user.CurrentDate.ToString("d MMMM yyyy");

            return View(viewModel);
        }

        public async Task<IActionResult> SimulateMatch(int matchId)
        {
            Console.WriteLine($"Requested matchId: {matchId}");
            var match = await _matchService.GetMatchWithPlayersAndAttributes(matchId);
            if (match == null)
            {
                Console.WriteLine($"Match not found for ID: {matchId}");
                return NotFound();
            }

            return View(match);
        }

        public async Task<IActionResult> RunSimulation([Required] int matchId)
        {
            if (matchId <= 0)
            {
                _logger.LogWarning("Invalid matchId: {MatchId}", matchId);
                return BadRequest(new
                {
                    error = "Invalid match ID",
                    details = "Match ID must be a positive number"
                });
            }

            try
            {
                var result = await _matchService.SimulateMatch(matchId);

                if (result == null)
                {
                    _logger.LogError("Simulation returned null for match {MatchId}", matchId);
                    return StatusCode(500, new
                    {
                        error = "Match simulation failed",
                        details = "Unable to simulate match"
                    });
                }

                return Ok(new
                {
                    winner = new
                    {
                        id = result.Winner.Id,
                        name = result.Winner.Name
                    },
                    sets = result.Sets.Select(s => new
                    {
                        p1Score = s.p1Score,
                        p2Score = s.p2Score
                    }),
                    setDetails = result.SetDetails.Select(sd => new
                    {
                        setNumber = sd.SetNumber,
                        games = sd.Games.Select(g => new
                        {
                            gameNumber = g.GameNumber,
                            winnerIsPlayer1 = g.WinnerIsPlayer1,
                            points = g.Points.Select(p => new
                            {
                                p1Score = p.P1ScoreDisplay,
                                p2Score = p.P2ScoreDisplay,
                                winnerIsPlayer1 = p.WinnerIsPlayer1
                            })
                        }),
                        p1Score = sd.P1Score,
                        p2Score = sd.P2Score
                    })
                });
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid argument for match {MatchId}", matchId);
                return BadRequest(new
                {
                    error = "Invalid match data",
                    details = ex.Message
                });
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogError(ex, "Operation error for match {MatchId}", matchId);
                return StatusCode(500, new
                {
                    error = "Match simulation failed",
                    details = ex.Message
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error simulating match {MatchId}", matchId);
                return StatusCode(500, new
                {
                    error = "Internal server error",
                    details = "An unexpected error occurred during match simulation"
                });
            }
        }
    }
}