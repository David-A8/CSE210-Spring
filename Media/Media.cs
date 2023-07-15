public abstract class Media
{
    protected int _mediaCode = 0;
    protected string _type = "";
    protected string _title = "";
    protected string _genre = "";
    protected int _year;
    protected int _calification = 0;
    protected int _numberRatings = 0;

    public virtual void NewMedia(int MediaCode)
    {
        Console.Write($"\nEnter Title: ");
        _title = Console.ReadLine() ?? string.Empty;
        Console.Write($"\nGenre: ");
        _genre = Console.ReadLine() ?? string.Empty;
        Console.Write($"\nYear of release: ");
        _year = int.Parse(Console.ReadLine() ?? string.Empty);
        _mediaCode = MediaCode;
    }

    public virtual void LoadingData(string[] Data)
    {
        _type = Data[0];
        _mediaCode = int.Parse(Data[1]);
        _title = Data[2];
        _genre = Data[3];
        _year = int.Parse(Data[4]);
        _calification = int.Parse(Data[5]);
        _numberRatings = int.Parse(Data[6]);
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

    public int GetCode(){
        return _mediaCode;
    }
}