namespace TennisSim.Models
{
    public class Draw
    {
        public Draw()
        {
            Tournament = null!;
            DrawMatches = new List<DrawMatch>();
            Schedules = new List<Schedule>();
        }

        public Draw(int tournamentId, int drawSize, int seedCount , int byeCount)
        {
            TournamentId = tournamentId;
            DrawSize = drawSize;
            SeedCount = seedCount;
            ByeCount = byeCount;
            Tournament = null!;
            DrawMatches = new List<DrawMatch>();
            Schedules = new List<Schedule>();
        }


        public int Id { get; set; }
        public int TournamentId { get; set; }
        public Tournament Tournament { get; set; }
        public int DrawSize { get; set; }
        public int SeedCount { get; set; }
        public int ByeCount { get; set; }
        public int UserId { get; set; }
        public UserName User { get; set; } = null!;
        public virtual ICollection<DrawMatch> DrawMatches { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; } 

    }

    public class DrawMatch
    {
        public DrawMatch()
        {
            Draw = null!;
            Player1 = null!;
            Player2 = null!;
            Winner = null!;
            Match = null!;
        }

        public DrawMatch(int drawId, int round, int matchNumber, int userId)
        {
            DrawId = drawId;
            Round = round;
            MatchNumber = matchNumber;
            Draw = null!;
            Player1 = null!;
            Player2 = null!;
            Winner = null!;
            Match = null!;
            IsBye = false;
        }

        public int Id { get; set; }
        public int DrawId { get; set; }
        public Draw Draw { get; set; }
        public int Round { get; set; }
        public int MatchNumber { get; set; }
        public int? Player1Id { get; set; }
        public int? Player2Id { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public bool IsBye { get; set; }
        public int? WinnerId { get; set; }
        public Player Winner { get; set; }
        public int? MatchId { get; set; }
        public Match Match { get; set; }
        public int? Player1SeedNumber { get; set; }
        public int? Player2SeedNumber { get; set; }
    }
}