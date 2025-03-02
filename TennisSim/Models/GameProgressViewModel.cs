namespace TennisSim.Models
{
    public class GameProgressViewModel
    {
        public GameProgressViewModel()
        {
            this.Username = string.Empty;
            this.CurrentDate = DateTime.Now;
        }

        public string Username { get; set; }
        public DateTime CurrentDate { get; set; }
    }
}