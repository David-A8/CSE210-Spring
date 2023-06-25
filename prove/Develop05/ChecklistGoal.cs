public class ChecklistGoal : Goal
{
    private int _timesToComplete;
    private int _extraPoints;

    public override void GetPoints()
    {
        base.GetPoints();
        Console.Write($"\nHow many times does this goal need to be accomplished for a bonus?: ");
        _timesToComplete = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write($"\nWhat is the bonus for accomplishing in that many times?: ");
        _extraPoints = int.Parse(Console.ReadLine() ?? string.Empty);
    }

    public override string GetStringRepresentation()
    {
        return "Checklist:"+_name + ":" + _description + ":" + _points + ":" + _completed + ":" + _timesToComplete +":"+_extraPoints;
    }

    public override void LoadingData(string[] Data)
    {
        base.LoadingData(Data);
        _timesToComplete = int.Parse(Data[6]);
        _extraPoints = int.Parse(Data[7]);
    }

    public override int MarkComplete()
    {
        if (_completed == false)
        {
            _timesToComplete -= 1;
            if (_timesToComplete == 0)
            {
                _completed = true;
                Console.WriteLine("Congrats!! You finished your Checklist Goal");
                Console.WriteLine($"You have earned {_points + _extraPoints} points");
                return _points + _extraPoints;
            }
            else
            {
                Console.WriteLine($"Congrasts!! You have earned {_points} points.");
                return _points;
            }
        }
        else
        {
            Console.WriteLine("This goal was already marked as completed.");
            return 0;
        }
    }
}