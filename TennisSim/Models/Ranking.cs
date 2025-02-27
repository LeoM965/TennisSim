namespace TennisSim.Models
{
    public class Ranking
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public DateTime Date { get; set; }
        public int Rank { get; set; }
        public int Points { get; set; }
        public int UserId { get; set; }
        public UserName User { get; set; }

        public Ranking()
        {
            Id = 0;
            PlayerId = 0;
            Date = DateTime.Now;
            Rank = 0;
            Points = 0;
            UserId = 0;
        }
    }
}