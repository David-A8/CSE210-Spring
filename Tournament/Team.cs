public class Team
{
    private List<Player> _roster = new List<Player>();
    private List<string> _sponsor = new List<string>();
    private string _name;
    private int _wins = 0;
    private int _losses = 0;

    public Team(string name)
    {
        _name = name;
    }

    public void AddPlayer(Player p)
    {
        foreach (Player existingPlayer in _roster)
        {
            if(p.GetJersey() == existingPlayer.GetJersey())
            {
                Console.WriteLine("Can't add a player with the same jersey number");
                return;
            }
        }
        _roster.Add(p);
    }

    public void Addwin()
    {
        _wins += 1;
    }

    public void AddLoss()
    {
        _losses += 1;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} {_wins}/{_losses}");
        foreach (Player p in _roster)
        {
            p.Display();
        }
    }

    public string GetTeam()
    {
        return _name;
    }




}