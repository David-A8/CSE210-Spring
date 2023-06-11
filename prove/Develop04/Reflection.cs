public class Reflection : StartingEnding
{
    List<string> _prompts = new List<string>{"Think of a time when you stood up for someone else",
    "Think of a time when you did something really difficult","Think of a time when you helped someone in need",
    "Think of a time when you did something truly selfless."};
    List<string> _questions = new List<string>{"Why was this experience meaningful to you?",
    "Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
    Random random = new Random();
    string _question;

    public Reflection(string Name, string Description) : base(Name, Description){}

    public void StartReflection()
    {
        _question = _prompts[random.Next(0,_prompts.Count)];
        Console.Write($"\n---{_question}---");
        Console.Write("\nWhen you have something in mind, press enter to continue");
        Console.Read();
        Console.Write("\nNow ponder on each of the following questions as they related to this experience");
        Thread.Sleep(5000);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            DisplayQuestion();
            currentTime = DateTime.Now;
        } 
    }

    public void DisplayQuestion()
    {
        Console.WriteLine($">{_questions[random.Next(0,_questions.Count)]}");
        Pause();
        Pause();
    }
}