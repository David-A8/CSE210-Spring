public abstract class Media
{
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
        Console.Write($"\nYear of releasing: ");
        _year = int.Parse(Console.ReadLine() ?? string.Empty);
    }

    public virtual void LoadingData(string[] Data)
    {
        _title = Data[1];
        _genre = Data[2];
        _year = int.Parse(Data[3]);
        _calification = int.Parse(Data[4]);
        _numberRatings = int.Parse(Data[5]);
    }

    public abstract string GetTxtInfo();
}