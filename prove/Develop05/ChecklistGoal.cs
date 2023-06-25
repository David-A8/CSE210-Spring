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
        _timesToComplete = int.Parse(Data[5]);
        _extraPoints = int.Parse(Data[6]);
    }

    public override int MarkComplete()
    {
        return base.MarkComplete();
    }
}