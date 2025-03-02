using TennisSim.Models;

public class ScheduleMatch
{
    public int Id { get; set; }
    public int ScheduleId { get; set; }
    public Schedule Schedule { get; set; } = new Schedule();
    public int DrawMatchId { get; set; }
    public DrawMatch DrawMatch { get; set; } = new DrawMatch();
    public string Court { get; set; } = string.Empty;
    public DateTime StartTime { get; set; } = DateTime.MinValue;
    public MatchStatus Status { get; set; } = MatchStatus.Scheduled;
    public string Round { get; set; } = string.Empty;
}

public enum MatchStatus
{
    Scheduled,
    InProgress,
    Completed,
    Postponed,
    Cancelled,
    Walkover
}