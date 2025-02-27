using TennisSim.Models;

namespace TennisSim.Services
{
    public interface IEntryListService
    {
        UserEntryList GetUserEntryList(int userId, int tournamentId);
        Draw GetTournamentDraw(int tournamentId);
        List<EntryList> GenerateEntryList(int tournamentId, int userId);
    }
}
