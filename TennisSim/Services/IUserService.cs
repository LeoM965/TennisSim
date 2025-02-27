using Microsoft.EntityFrameworkCore;
using TennisSim.Models;

namespace TennisSim.Services
{
    public interface IUserService
    {
        UserName GetUserByUsername(string username);
        UserName GetUserById(int userId);
        void UpdateUser(UserName user);
        bool HasUpcomingTournament(int userId);
        bool HasViewedEntryList(int userId);
        bool HasViewedDraw(int userId);
    }
}
