namespace TennisSim.Models
{
    public class PointDistribution
    {
        public int Id { get; set; }
        public TournamentCategory Category { get; set; }
        public string Round { get; set; }
        public int Points { get; set; }

        public PointDistribution()
        {
            Id = 0;
            Category = new TournamentCategory();
            Round = string.Empty;
            Points = 0;
        }
    }
}