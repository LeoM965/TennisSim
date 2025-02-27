using TennisSim.Models;

public class Match
{
    public int Id { get; set; }
    public int Player1Id { get; set; }
    public int Player2Id { get; set; }
    public int DrawId { get; set; }
    public DateTime Date { get; set; }
    public int WinnerId { get; set; }
    public string Score { get; set; } = string.Empty;
    public string Round { get; set; } = string.Empty;
    public Player Player1 { get; set; } = null!;
    public Player Player2 { get; set; } = null!;
    public Draw Draw { get; set; } = null!;
    public Player Winner { get; set; } = null!;
    public MatchStatus Status { get; set; } = MatchStatus.Scheduled;
    public Match() { }

    public Match(int player1Id, int player2Id, int drawId, DateTime date)
    {
        Player1Id = player1Id;
        Player2Id = player2Id;
        DrawId = drawId;
        Date = date;
    }
}

public class MatchViewModel
{
    public Tournament Tournament { get; set; } = null!;
    public Match Match { get; set; } = null!;
    public IEnumerable<PlayerAttribute> Player1Attributes { get; set; } = new List<PlayerAttribute>();
    public IEnumerable<PlayerAttribute> Player2Attributes { get; set; } = new List<PlayerAttribute>();

    public MatchViewModel() { }

    public MatchViewModel(
        Tournament tournament,
        Match match,
        IEnumerable<PlayerAttribute> player1Attributes,
        IEnumerable<PlayerAttribute> player2Attributes)
    {
        Tournament = tournament;
        Match = match;
        Player1Attributes = player1Attributes;
        Player2Attributes = player2Attributes;
    }
}

public class MatchDetailsViewModel
{
    public List<Match> HeadToHeadMatches { get; set; } = new List<Match>();
    public int Player1Id { get; set; }
    public int Player2Id { get; set; }
    public string Player1Name { get; set; } = string.Empty;
    public string Player2Name { get; set; } = string.Empty;
    public int Player1Wins { get; set; }
    public int Player2Wins { get; set; }
    public string LastMatchDate { get; set; } = string.Empty;
    public Dictionary<string, int> RoundStats { get; set; } = new Dictionary<string, int>();
    public string TournamentName { get; set; } = string.Empty;
    public Nationality Player1Nationality { get; set; } = null!;
    public Nationality Player2Nationality { get; set; } = null!;
    public int UserId { get; set; } 
    public MatchDetailsViewModel() { }

    public MatchDetailsViewModel(int player1Id, int player2Id, string player1Name, string player2Name)
    {
        Player1Id = player1Id;
        Player2Id = player2Id;
        Player1Name = player1Name;
        Player2Name = player2Name;
    }
}