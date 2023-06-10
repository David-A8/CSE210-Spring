public class Breathing : StartingEnding
{
    int _timeLeft;
    public Breathing(string Name, string Description) : base(Name, Description){}
    
    public void BreathIn()
    {
        Console.Write("\nBreathe in...");
        int j = 6;
        if (_timeLeft <= 6)
        {
            j = _timeLeft;
        }
        for (int i = j ; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            _timeLeft --;
        }
    }

    public void BreathOut()
    {
        Console.Write("\nBreathe out...");
        int j = 6;
        if (_timeLeft <= 6)
        {
            j = _timeLeft;
        }
        else
        {
            j = 6;
        }
        for (int i = j ; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            _timeLeft--;
        }
    }

    public void StartBreathing()
    {
        _timeLeft = _duration;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            BreathIn();
            if (currentTime < futureTime)
            {
                BreathOut();
            }
            currentTime = DateTime.Now;
        }
    }
}