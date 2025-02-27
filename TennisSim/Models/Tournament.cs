namespace TennisSim.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? QualifyingStartDate { get; set; }
        public DateTime? QualifyingEndDate { get; set; }
        public string Surface { get; set; }
        public TournamentCategory Category { get; set; }
        public int QualifyingRounds { get; set; }
        public ICollection<Draw> Draws { get; set; }
        public ICollection<Match> Matches { get; set; }
        public ICollection<PointDistribution> PointDistributions { get; set; }
        public ICollection<UserEntryList> UserEntryLists { get; set; }
        public ICollection<Schedule> Schedules { get; set; }

        public Tournament()
        {
            Id = 0;
            Name = string.Empty;
            Location = string.Empty;
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            QualifyingStartDate = null;
            QualifyingEndDate = null;
            Surface = string.Empty;
            Category = TournamentCategory.GrandSlam;
            QualifyingRounds = 0;
            Draws = new List<Draw>();
            Matches = new List<Match>();
            PointDistributions = new List<PointDistribution>();
            UserEntryLists = new List<UserEntryList>();
            Schedules = new List<Schedule>();
        }
    }

    public enum TournamentCategory
    {
        GrandSlam = 0,
        Masters1000 = 1,
        Masters500 = 2,
        Masters250 = 3,
        ITF100K = 4,
        ITF50K = 5,
        ITF25K = 6,
        ITF10K = 7,
        Challenger = 8
    }
}