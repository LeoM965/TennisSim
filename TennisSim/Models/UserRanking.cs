namespace TennisSim.Models
{
    public class UserRanking
    {
        public int UserId { get; set; }
        public int PlayerId { get; set; } 
        public DateTime Date { get; set; }
        public int Rank { get; set; }
        public int Points { get; set; }
        public UserName User { get; set; }
        public Player Player { get; set; }
    }
}
