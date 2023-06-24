using System.IO;
public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    private bool _completed = false;

    public void GetName()
    {
        Console.Write($"\nWhat is the name of your goal?: ");
        _name = Console.ReadLine() ?? String.Empty;
    }

    public void GetDescription()
    {
        Console.Write($"\nWhat is the description of your goal?: ");
        _description = Console.ReadLine() ?? String.Empty;
    }

    public virtual void GetPoints()
    {
        Console.Write($"\nWhat is the amoung of points associated with this goal?: ");
        _points = int.Parse(Console.ReadLine() ?? String.Empty);
    }

    public void Display()
    {
        if (_completed == false)
        {
            Console.WriteLine($"{_name} ({_description}) [ ]");
        }
        else
        {
            Console.WriteLine($"{_name} ({_description}) [X]");
        }
        
    }

    public virtual void MarkComplete()
    {
        _completed = true;
    }
}