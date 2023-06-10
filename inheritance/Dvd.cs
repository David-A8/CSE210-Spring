public class Dvd : Loanable
{
    private string _title;
    private int _runTime;

    public Dvd(string title, int runTime)
    {
        _title = title;
        _runTime = runTime;
    }

    public override void Display()
    {
        Console.WriteLine($"Title: {_title}");
        base.Display();
    }
}