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
