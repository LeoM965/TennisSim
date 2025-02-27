using TennisSim.Models;

namespace TennisSim.Services
{
    public interface ITournamentService
    {
        List<Tournament> GetAllTournaments();
        Tournament GetTournamentById(int id);
        List<PointDistribution> GetPointDistributions(TournamentCategory category);
        List<Schedule> GenerateTournamentSchedule(int tournamentId, Draw draw);
        Task<bool> HasUnplayedMatches(int tournamentId);
        Task<ScheduleMatch> GetNextUnplayedMatch(int tournamentId);
        List<DateTime> GetAvailableDates(int tournamentId, DateTime startDate, DateTime currentDate);
        List<Schedule> GetTournamentScheduleForDate(int tournamentId, Draw draw, DateTime currentDate);
    }
}
