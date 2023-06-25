using System.IO;
public class Goals
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    public void AddGoal(Goal NewGoal)
    {
        _goals.Add(NewGoal);
    }

    public void DisplayGoals()
    {
        Console.Clear();
        Console.WriteLine("List of Goals");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"\n  {i+1}. ");
            _goals[i].Display();
        }
        Console.Write("\n\nPress Enter to continue ");
        Console.ReadLine();
    }

    public void SaveFile(string FileName)
    {
        using(StreamWriter outputFile = new StreamWriter(FileName+".txt"))
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                outputFile.WriteLine($"{_totalPoints}:{_goals[i].GetStringRepresentation()}");
            }
        }
        Console.WriteLine("File created successfully!!!");
        Thread.Sleep(2500);
    }

    public void LoadFile(string fileName)
    {
        _goals.Clear();
        string[] lines = System.IO.File.ReadAllLines(fileName+".txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            _totalPoints = int.Parse(parts[0]);
            if (parts[1] == "Checklist")
            {
                _goals.Add(new ChecklistGoal());
                _goals[_goals.Count - 1].LoadingData(parts);
            }
            else if (parts[1] == "Eternal")
            {
                _goals.Add(new EternalGoal());
                _goals[_goals.Count - 1].LoadingData(parts);
            }
            else
            {
                _goals.Add(new SimpleGoal());
                _goals[_goals.Count - 1].LoadingData(parts);
            }
        }
        Console.WriteLine("File loaded successfully!!!");
        Thread.Sleep(2500);
    }

    public void MarkComplete()
    {
        Console.Clear();
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"  {i+1}. ");
            _goals[i].ReturnName();
        }
        Console.Write("\nWhich goal did you accomplish?: ");
        int GoalComplete = int.Parse(Console.ReadLine() ?? String.Empty);
        _totalPoints += _goals[GoalComplete-1].MarkComplete();
        Console.WriteLine($"You have now {_totalPoints} points.");
        Thread.Sleep(3000);
    }

    public int DisplayPoints()
    {
        return _totalPoints;
    }

    public Goal LastGoal()
    {
        return _goals[_goals.Count-1];
    }
}