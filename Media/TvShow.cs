public class TvShow : Media
{

    int _seasons;
    string _rate = "";
    string _platform = "";

    public override void NewMedia()
    {
        _type = "TvShow";
        Console.WriteLine("New TvShow");
        base.NewMedia();
        Console.Write($"\nNumber of seasons: ");
        _seasons = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("\nTv show created successfully");
    }
    public override string GetTxtInfo()
    {
        return "TvShow:/"+_title+":/"+_genre+":/"+ _year+":/"+_calification+":/"+_numberRatings+":/"+_seasons+":/"+_rate+":/"+_platform;
    }
    public override void LoadingData(string[] Data)
    {
        base.LoadingData(Data);
        _seasons = int.Parse(Data[6]);
        _rate = Data[7];
        _platform = Data[8];
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Seasons: {_seasons}");
        Console.WriteLine($"Rate: {_rate}");
        Console.WriteLine($"Platform: {_platform}");
        Console.WriteLine($"Calification: {_calification}");
    }
}