using TennisSim.Models;

public class Nationality
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public ICollection<Player> Players { get; set; }

    public Nationality()
    {
        Name = string.Empty;
        Code = string.Empty;
        Players = new List<Player>();
    }

}