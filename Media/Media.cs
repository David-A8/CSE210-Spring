public abstract class Media
{
    protected string _type = "";
    protected string _title = "";
    protected string _genre = "";
    protected int _year;
    protected int _calification = 0;
    protected int _numberRatings = 0;

    public virtual void NewMedia()
    {
        Console.Write($"\nEnter Title: ");
        _title = Console.ReadLine() ?? string.Empty;
        Console.Write($"\nGenre: ");
        _genre = Console.ReadLine() ?? string.Empty;
        Console.Write($"\nYear of release: ");
        _year = int.Parse(Console.ReadLine() ?? string.Empty);
    }

    public virtual void LoadingData(string[] Data)
    {
        _type = Data[0];
        _title = Data[1];
        _genre = Data[2];
        _year = int.Parse(Data[3]);
        _calification = int.Parse(Data[4]);
        _numberRatings = int.Parse(Data[5]);
    }

    public abstract string GetTxtInfo();

    public virtual void ShowInfo()
    {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Genre: {_genre}");
        Console.WriteLine($"Year of release: {_year}");
    }

    public string Type()
    {
        return _type;
    }
    
    public string Title(){
        return _title;
    }

    public int Year(){
        return _year;
    }
}