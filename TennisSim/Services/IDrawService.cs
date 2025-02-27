using TennisSim.Models;

namespace TennisSim.Services
{
    public interface IDrawService
    {
        Draw CreateNewDraw(Tournament tournament, List<EntryList> entryList, int userId);
        void ProcessByeMatches(List<DrawMatch> matches);
        DrawMatch GetNextMatch(DrawMatch currentMatch, List<DrawMatch> allMatches);
        List<DrawMatch> GenerateDrawMatches(int drawId, List<EntryList> entryList, int drawSize, int byeCount,
            int seedCount, Dictionary<string, Player> preloadedPlayers);
        void UpdateUserEntryListsViewStatus(int tournamentId);
    }
}