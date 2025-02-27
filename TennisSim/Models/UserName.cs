namespace TennisSim.Models
{
    public class UserName
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime CurrentDate { get; set; } = new DateTime(2023, 12, 23);
        public ICollection<UserEntryList> UserEntryLists { get; set; } = new List<UserEntryList>();
        public ICollection<Draw> Draws { get; set; } = new List<Draw>();
        public ICollection<DrawMatch> DrawMatches { get; set; } = new List<DrawMatch>();

        public UserName()
        {
            Id = 0;
            Username = string.Empty;
            CurrentDate = new DateTime(2023, 12, 23);
            UserEntryLists = new List<UserEntryList>();
            Draws = new List<Draw>();
            DrawMatches = new List<DrawMatch>();
        }
    }
}