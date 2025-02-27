using TennisSim.Models;

namespace TennisSim.Services
{
    public interface IMatchService
    {
        Task<MatchViewModel> GetMatchWithPlayersAndAttributes(int matchId);
        Task<MatchSimulationResult> SimulateMatch(int matchId);
    }
}
