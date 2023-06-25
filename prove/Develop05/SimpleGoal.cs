public class SimpleGoal : Goal
{
    public override string GetStringRepresentation()
    {
        return "Simple:"+_name + ":" + _description + ":" + _points + ":" + _completed;
    }
}