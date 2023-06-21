public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    private bool _completed = false;

    public void GetName(string name)
    {
        _name = name;
    }

    public void GetDescription(string description)
    {
        _description = description;
    }

    public void GetPoints(int points)
    {
        _points = points;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} ({_description})");
    }
}