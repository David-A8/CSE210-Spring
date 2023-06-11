public class StartingEnding
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public StartingEnding(string Name, string Description)
    {
        _name = Name;
        _description = Description;
    }

    public void StartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_name}.\n\n{_description}.");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Get ready...");
        Pause();
    }

    public void EndingMessage()
    {
        Console.WriteLine($"\n\nWell Done!!");
        Pause();
        Console.WriteLine($"\n\nYou have completed another {_duration} seconds of {_name}.");
        Pause();
    }

    public void Pause()
    {
        for (int i = 0; i<=1; i++)
        {
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("—");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}