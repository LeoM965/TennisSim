using Microsoft.EntityFrameworkCore;
using TennisSim.Data;
using TennisSim.Models;
using TennisSim.Services;

public class EntryListService : IEntryListService
{
    private readonly ApplicationDbContext _context;
    private readonly Random _random;

    public EntryListService(ApplicationDbContext context)
    {
        _context = context;
        _random = new Random();
    }

    public UserEntryList GetUserEntryList(int userId, int tournamentId)
    {
        UserName? user = _context.UserNames.FirstOrDefault(u => u.Id == userId);
        if (user == null)
            throw new InvalidOperationException($"User with ID {userId} not found.");

        Tournament? tournament = _context.Tournaments.FirstOrDefault(t => t.Id == tournamentId);
        if (tournament == null)
            throw new InvalidOperationException($"Tournament with ID {tournamentId} not found.");

        UserEntryList? entryList = _context.UserEntryLists
            .Include(uel => uel.EntryList)
            .FirstOrDefault(uel => uel.UserNameId == userId &&
                                  uel.TournamentId == tournamentId);

        if (entryList == null)
        {
            GenerateEntryList(tournamentId, userId);

            entryList = _context.UserEntryLists
                .Include(uel => uel.EntryList)
                .FirstOrDefault(uel => uel.UserNameId == userId &&
                                      uel.TournamentId == tournamentId);

            if (entryList == null)
                throw new InvalidOperationException("Failed to generate or retrieve entry list.");
        }

        return entryList;
    }
    public Draw GetTournamentDraw(int tournamentId)
    {
        return _context.Draws
            .Include(d => d.DrawMatches)
                .ThenInclude(dm => dm.Player1)
            .Include(d => d.DrawMatches)
                .ThenInclude(dm => dm.Player2)
            .FirstOrDefault(d => d.TournamentId == tournamentId)
            ?? throw new KeyNotFoundException($"Draw not found for tournament {tournamentId}");
    }

    public List<EntryList> GenerateEntryList(int tournamentId, int userId)
    {
        Tournament? tournament = _context.Tournaments.Find(tournamentId);
        UserName? user = _context.UserNames.Find(userId);

        if (tournament == null || user == null)
            return new List<EntryList>();

        DateTime tournamentWeekStart = tournament.StartDate.Date.AddDays(-(int)tournament.StartDate.DayOfWeek);
        DateTime tournamentWeekEnd = tournamentWeekStart.AddDays(6);

        List<string> playersInOtherTournaments = _context.UserEntryLists
            .Where(uel => uel.UserNameId == userId)
            .Where(uel => uel.Tournament.StartDate >= tournamentWeekStart &&
                         uel.Tournament.StartDate <= tournamentWeekEnd)
            .SelectMany(uel => uel.EntryList.Select(el => el.PlayerName))
            .Distinct()
            .ToList();

        var activePlayers = _context.Players
            .Where(p => p.Active)
            .Select(p => new
            {
                p.Id,
                p.Name,
                LatestRanking = p.Rankings
                    .Where(r => r.Date <= user.CurrentDate)
                    .OrderByDescending(r => r.Date)
                    .FirstOrDefault()
            })
            .Where(p => p.LatestRanking != null)
            .Where(p => !playersInOtherTournaments.Contains(p.Name))
            .ToList()
            .Select(p => new
            {
                p.Name,
                Rank = p.LatestRanking?.Rank ?? int.MaxValue,
                Points = p.LatestRanking?.Points ?? 0,
            })
            .OrderBy(p => p.Rank)
            .ToList();

        int maxEntries = GetMaxEntries(tournament.Category);

        var eligiblePlayers = activePlayers
            .Where(p => IsEligible(p.Rank, tournament.Category))
            .Select(p => new
            {
                p.Name,
                p.Rank,
                p.Points,
                EntryChance = CalculateEntryChance(p.Rank, tournament.Category)
            })
            .Where(p => _random.NextDouble() <= p.EntryChance)
            .OrderBy(p => p.Rank)
            .Take(maxEntries)
            .ToList();

        UserEntryList userEntryList = new UserEntryList
        {
            UserNameId = userId,
            TournamentId = tournamentId,
            User = user,
            Tournament = tournament,
            EntryList = new List<EntryList>()
        };

        _context.UserEntryLists.Add(userEntryList);
        _context.SaveChanges();

        List<EntryList> entryList = eligiblePlayers.Select(p => new EntryList
        {
            PlayerName = p.Name,
            Rank = p.Rank,
            Points = p.Points,
            UserEntryListId = userEntryList.Id,
            UserEntryList = userEntryList
        }).ToList();

        _context.EntryLists.AddRange(entryList);
        _context.SaveChanges();

        return entryList;
    }

    private static int GetMaxEntries(TournamentCategory category) => category switch
    {
        TournamentCategory.GrandSlam => 128,
        TournamentCategory.Masters1000 => 96,
        TournamentCategory.Masters500 => 48,
        TournamentCategory.Masters250 => 32,
        TournamentCategory.Challenger => 32,
        TournamentCategory.ITF100K => 32,
        TournamentCategory.ITF50K => 32,
        TournamentCategory.ITF25K => 32,
        TournamentCategory.ITF10K => 32,
        _ => 32
    };

    private static bool IsEligible(int rank, TournamentCategory category) => category switch
    {
        TournamentCategory.GrandSlam => rank <= 196,
        TournamentCategory.Masters1000 => rank <= 196,
        TournamentCategory.Masters500 => rank <= 160,
        TournamentCategory.Masters250 => rank <= 170,
        TournamentCategory.Challenger => rank is >= 30 and <= 250,
        TournamentCategory.ITF100K => rank is >= 50 and <= 400,
        TournamentCategory.ITF50K => rank is >= 150 and <= 400,
        TournamentCategory.ITF25K => rank is >= 200 and <= 400,
        TournamentCategory.ITF10K => rank is >= 300 and <= 400,
        _ => true
    };

    private static double CalculateEntryChance(int rank, TournamentCategory category) => category switch
    {
        TournamentCategory.GrandSlam when rank <= 50 => 1.00,
        TournamentCategory.GrandSlam when rank is >= 51 and <= 100 => 0.95,
        TournamentCategory.GrandSlam when rank is >= 101 and <= 196 => 0.8,
        TournamentCategory.GrandSlam => 0.0,

        TournamentCategory.Masters1000 when rank <= 30 => 1.00,
        TournamentCategory.Masters1000 when rank is >= 31 and <= 80 => 0.9,
        TournamentCategory.Masters1000 when rank is >= 81 and <= 196 => 0.6,
        TournamentCategory.Masters1000 => 0.0,

        TournamentCategory.Masters500 when rank <= 40 => 0.65,
        TournamentCategory.Masters500 when rank is >= 41 and <= 90 => 0.7,
        TournamentCategory.Masters500 when rank is >= 91 and <= 196 => 0.5,
        TournamentCategory.Masters500 => 0.25,

        TournamentCategory.Masters250 when rank is <= 20 => 0.1,
        TournamentCategory.Masters250 when rank is >= 21 and <= 39 => 0.2,
        TournamentCategory.Masters250 when rank is >= 40 and <= 79 => 0.3,
        TournamentCategory.Masters250 when rank is >= 80 and <= 99 => 0.4,
        TournamentCategory.Masters250 when rank is >= 100 and <= 120 => 0.45,
        TournamentCategory.Masters250 when rank is >= 121 and <= 170 => 0.5,
        TournamentCategory.Masters250 => 0.0,

        TournamentCategory.Challenger when rank is >= 30 and <= 80 => 0.1,
        TournamentCategory.Challenger when rank is >= 80 and <= 100 => 0.7,
        TournamentCategory.Challenger when rank is >= 100 and <= 150 => 0.5,
        TournamentCategory.Challenger when rank is >= 150 and <= 250 => 0.7,
        TournamentCategory.Challenger => 0.0,

        TournamentCategory.ITF100K when rank is >= 50 and <= 99 => 0.05,
        TournamentCategory.ITF100K when rank is >= 100 and <= 149 => 0.45,
        TournamentCategory.ITF100K when rank is >= 150 and <= 250 => 0.45,
        TournamentCategory.ITF100K when rank is >= 249 and <= 350 => 0.6,
        TournamentCategory.ITF100K when rank is >= 351 and <= 400 => 0.4,
        TournamentCategory.ITF100K => 0.0,

        TournamentCategory.ITF50K when rank is >= 200 and <= 300 => 0.7,
        TournamentCategory.ITF50K when rank is >= 301 and <= 350 => 0.6,
        TournamentCategory.ITF50K when rank is >= 351 and <= 400 => 0.2,

        TournamentCategory.ITF25K when rank is >= 200 and <= 249 => 0.15,
        TournamentCategory.ITF25K when rank is >= 250 and <= 350 => 0.60,
        TournamentCategory.ITF25K when rank is >= 351 and <= 400 => 0.4,

        TournamentCategory.ITF10K when rank is >= 300 and <= 350 => 0.2,
        TournamentCategory.ITF10K when rank is >= 351 and <= 400 => 0.8,
        TournamentCategory.ITF10K => 0.0,

        _ => 0.0
    };
}