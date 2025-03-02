namespace TennisSim.Models
{
    public class DrawMatch
    {
        public DrawMatch()
        {
            this.Draw = null!;
            this.Player1 = null!;
            this.Player2 = null!;
            this.Winner = null!;
            this.Match = null!;
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