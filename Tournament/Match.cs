public class Match
{
    Team _team1;
    Team _team2;

    public Match(Team t1, Team t2)
    {
        _team1 = t1;
        _team2 = t2;
    }

    public void DecideWin()
    {
        Console.WriteLine("Which Team Won?");
        Console.WriteLine($"1) {_team1.GetTeam()}");
        Console.WriteLine($"2) {_team2.GetTeam()}");
        string winner = Console.ReadLine();
        if(winner == "1")
        {
            _team1.Addwin();
            _team2.AddLoss();
        }
        else
        {
            _team1.AddLoss();
            _team2.AddLoss();
        }

        _team1.Display();
        _team2.Display();
    }



}