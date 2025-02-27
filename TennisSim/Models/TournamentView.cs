namespace TennisSim.Models
{
    public class TournamentView
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime TournamentDate { get; set; }
        public bool HasViewedEntryList { get; set; }
        public bool HasViewedDraw { get; set; }

        public TournamentView()
        {
            Id = 0;
            Username = string.Empty;
            TournamentDate = DateTime.Now;
            HasViewedEntryList = false;
            HasViewedDraw = false;
        }
    }

    public class GameStartViewModel
    {
        public string Username { get; set; }
        public DateTime CurrentDate { get; set; } = new DateTime(2023, 12, 23);

        public GameStartViewModel()
        {
            Username = string.Empty;
            CurrentDate = new DateTime(2023, 12, 23);
        }
    }
}