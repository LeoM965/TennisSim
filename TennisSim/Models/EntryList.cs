namespace TennisSim.Models
{
    public class EntryList
    {
        public EntryList()
        {
            this.PlayerName = string.Empty;
            this.UserEntryList = new UserEntryList();
            this.IsSeeded = false;
            this.HasBye = false;
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