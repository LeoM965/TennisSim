using System.ComponentModel.DataAnnotations;
using TennisSim.Models;

public class TournamentScheduleViewModel
{
    [Required(ErrorMessage = "Tournament name is required.")]
    public string TournamentName { get; set; } = string.Empty;

    [Range(1, int.MaxValue, ErrorMessage = "Invalid Tournament ID.")]
    public int TournamentId { get; set; }

    public List<Schedule> Schedule { get; set; } = new List<Schedule>();
    public DateTime CurrentDate { get; set; } = DateTime.Now;
    public DateTime SelectedDate { get; set; } = DateTime.Now;
    public List<DateTime> AvailableDates { get; set; } = new List<DateTime>();
    public bool HasUnplayedMatches { get; set; }
}

public class Schedule
{
    public int Id { get; set; }
    public int DrawId { get; set; }
    public DateTime Date { get; set; } = DateTime.MinValue;
    public Draw Draw { get; set; } = new Draw();
    public List<ScheduleMatch> ScheduledMatches { get; set; } = new List<ScheduleMatch>();
}

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