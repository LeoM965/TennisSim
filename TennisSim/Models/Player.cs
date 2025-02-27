namespace TennisSim.Models
{
    public class Player
    {
        public Player()
        {
            Name = string.Empty;
            Nationality = null!;
            Attributes = new List<PlayerAttribute>();
            MatchesAsPlayer1 = new List<Match>();
            MatchesAsPlayer2 = new List<Match>();
            Rankings = new List<Ranking>();
            Active = true;
        }

        public Player(string name, int yearOfBirth, int nationalityId)
            : this() 
        {
            Name = name;
            YearOfBirth = yearOfBirth;
            NationalityId = nationalityId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        public int NationalityId { get; set; }
        public int Ranking { get; set; }
        public bool Active { get; set; }
        public Nationality Nationality { get; set; }
        public ICollection<PlayerAttribute> Attributes { get; set; }
        public ICollection<Match> MatchesAsPlayer1 { get; set; }
        public ICollection<Match> MatchesAsPlayer2 { get; set; }
        public ICollection<Ranking> Rankings { get; set; }
        public int LatestPoints => Rankings?.OrderByDescending(r => r.Date).FirstOrDefault()?.Points ?? 0;
    }

    public class PlayerDetailsViewModel
    {
        public PlayerDetailsViewModel()
        {
            Player = null!;
            RecentMatches = new List<Match>();
            TotalWins = 0;
            TotalMatches = 0;
            WinPercentage = 0;
        }

        public PlayerDetailsViewModel(Player player, List<Match> recentMatches)
        {
            Player = player;
            RecentMatches = recentMatches;
            TotalMatches = player.MatchesAsPlayer1.Count + player.MatchesAsPlayer2.Count;
            TotalWins = CalculateWins(player);
            WinPercentage = TotalMatches > 0 ? (double)TotalWins / TotalMatches * 100 : 0;
        }

        private int CalculateWins(Player player)
        {
            var winsAsPlayer1 = player.MatchesAsPlayer1.Count(m => m.WinnerId == player.Id);
            var winsAsPlayer2 = player.MatchesAsPlayer2.Count(m => m.WinnerId == player.Id);
            return winsAsPlayer1 + winsAsPlayer2;
        }

        public Player Player { get; set; }
        public List<Match> RecentMatches { get; set; }
        public int TotalWins { get; set; }
        public int TotalMatches { get; set; }
        public double WinPercentage { get; set; }
    }
}