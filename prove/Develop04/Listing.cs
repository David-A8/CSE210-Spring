public class Listing : StartingEnding
{
    List<string> _prompts = new List<string>{"Who are people that you appreciate?",
    "What are personal strengths of yours?","Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    List<string> _responses = new List<string>{};
    Random random = new Random();
    string _question;
    
    public Listing(string Name, string Description) : base(Name, Description){}
    public void StartListing()
    {
        Console.WriteLine("List as many responses you can to the following prompt: ");
        _question = _prompts[random.Next(0,_prompts.Count)];
        Console.WriteLine($"\n---{_question}---");
        Pause();
        Pause();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            GetResponses();
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {_responses.Count} items!");
    }

    public void GetResponses()
    {
        Console.Write("\n>");
        _responses.Add(Console.ReadLine());
    }
    



}