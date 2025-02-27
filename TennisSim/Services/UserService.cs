using Microsoft.EntityFrameworkCore;
using TennisSim.Data;
using TennisSim.Models;

namespace TennisSim.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public UserName GetUserByUsername(string username)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(username))
                    throw new ArgumentNullException(nameof(username), "Username cannot be null or empty");

                username = username.Trim();

                var user = _context.UserNames
                    .FirstOrDefault(u => u.Username.ToLower() == username.ToLower())
                    ?? throw new KeyNotFoundException($"User '{username}' not found");

                return user;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving user with username '{username}'", ex);
            }
        }

        public UserName GetUserById(int userId)
        {
            return _context.UserNames
                .FirstOrDefault(u => u.Id == userId);
        }
        public void UpdateUser(UserName user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user), "User cannot be null");

            var existingUser = _context.UserNames.Find(user.Id);
            if (existingUser == null)
                throw new KeyNotFoundException($"User with ID {user.Id} not found");

            _context.Entry(existingUser).CurrentValues.SetValues(user);
            _context.SaveChanges();
        }

        public bool HasUpcomingTournament(int userId)
        {
            var user = GetUserById(userId);
            if (user == null) return false;

            var targetDate = user.CurrentDate.AddDays(2);
            return _context.Tournaments
                .Any(t => t.StartDate.Date == targetDate.Date);
        }
        public bool HasViewedEntryList(int userId)
        {
            var user = GetUserById(userId);
            if (user == null) return false;

            var targetDate = user.CurrentDate.AddDays(2);
            var upcomingTournament = _context.Tournaments
                .FirstOrDefault(t => t.StartDate.Date == targetDate.Date);

            if (upcomingTournament == null) return false;

            return _context.UserEntryLists
                .Any(uel => uel.UserNameId == user.Id &&
                           uel.TournamentId == upcomingTournament.Id);
        }

        public bool HasViewedDraw(int userId)
        {
            var user = GetUserById(userId);
            if (user == null) return false;

            var targetDate = user.CurrentDate.AddDays(2);
            var upcomingTournament = _context.Tournaments
                .FirstOrDefault(t => t.StartDate.Date == targetDate.Date);

            if (upcomingTournament == null) return false;

            return _context.UserEntryLists
                .Any(uel => uel.UserNameId == user.Id &&
                           uel.TournamentId == upcomingTournament.Id &&
                           uel.HasViewedDraw);
        }


        
    }
}