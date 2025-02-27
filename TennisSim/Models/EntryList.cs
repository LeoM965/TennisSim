namespace TennisSim.Models
{
    public class UserEntryList
    {
        public UserEntryList()
        {
            EntryList = new List<EntryList>();
            User = null!;
            Tournament = null!;
        }

        public UserEntryList(int userNameId, int tournamentId)
        {
            UserNameId = userNameId;
            TournamentId = tournamentId;
            EntryList = new List<EntryList>();
            User = null!;
            Tournament = null!;
            HasViewedDraw = false;
        }

        public int Id { get; set; }
        public int UserNameId { get; set; }
        public int TournamentId { get; set; }
        public List<EntryList> EntryList { get; set; }
        public UserName User { get; set; }
        public Tournament Tournament { get; set; }
        public bool HasViewedDraw { get; set; }
    }

    public class EntryList
    {
        public EntryList()
        {
            PlayerName = string.Empty;
            UserEntryList = null!;
        }

        public EntryList(string playerName, int rank, int points, int userEntryListId)
        {
            PlayerName = playerName;
            Rank = rank;
            Points = points;
            UserEntryListId = userEntryListId;
            UserEntryList = null!;
            IsSeeded = false;
            HasBye = false;
        }

        public int Id { get; set; }
        public string PlayerName { get; set; }
        public int Rank { get; set; }
        public int Points { get; set; }
        public int UserEntryListId { get; set; }
        public bool IsSeeded { get; set; }
        public int? SeedNumber { get; set; }
        public bool HasBye { get; set; }
        public UserEntryList UserEntryList { get; set; }
    }
}