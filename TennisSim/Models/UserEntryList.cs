namespace TennisSim.Models
{
    public class UserEntryList
    {
        public UserEntryList()
        {
            this.EntryList = new List<EntryList>();
            this.User = new UserName(); 
            this.Tournament = new Tournament(); 
            this.HasViewedDraw = false;
        }

        public int Id { get; set; }
        public int UserNameId { get; set; }
        public int TournamentId { get; set; }
        public List<EntryList> EntryList { get; set; }
        public UserName User { get; set; }
        public Tournament Tournament { get; set; }
        public bool HasViewedDraw { get; set; }
    }
}


