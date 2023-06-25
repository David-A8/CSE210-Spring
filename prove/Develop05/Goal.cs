using System.IO;
public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _completed = false;

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
            Console.Write($"{_name} ({_description}) [ ]");
        }
        else
        {
            Console.Write($"{_name} ({_description}) [X]");
        }
    }

    public string ReturnName()
    {
        return _name;
    }

    public virtual int MarkComplete()
    {
        if (_completed == false)
        {
            _completed = true;
            Console.WriteLine($"Congrats!! You have earned {_points} points");
            return _points;
        }
        else
        {
            Console.WriteLine("This goal was already marked as completed");
            return 0;
        }
    }

    public abstract string GetStringRepresentation();
    public virtual void LoadingData(string[] Data)
    {
        _name = Data[1];
        _description = Data[2];
        _points = int.Parse(Data[3]);
        if (Data[4]== "true")
        {
            _completed = true;
        }
        else
        {
            _completed = false;
        }
    }
}