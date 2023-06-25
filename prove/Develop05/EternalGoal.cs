public class EternalGoal : Goal
{
    public override string GetStringRepresentation()
    {
        return "Eternal:"+_name + ":" + _description + ":" + _points + ":" + _completed;
    }

    public override int MarkComplete()
    {
        Console.WriteLine($"Congrats! You have earned {_points} points");
        return _points;
    }
}