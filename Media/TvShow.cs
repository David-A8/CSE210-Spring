public class TvShow : Media
{

    int _seasons;
    string _rate = "";
    string _platform = "";

    public override void NewMedia(int MediaCode)
    {
        _type = "TvShow";
        Console.WriteLine("New TvShow");
        base.NewMedia(MediaCode);
        Console.Write($"\nNumber of seasons: ");
        _seasons = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("\nTv show created successfully");
    }
    public override string GetTxtInfo()
    {
        return "TvShow:/"+_mediaCode+":/"+_title+":/"+_genre+":/"+ _year+":/"+_calification+":/"+_numberRatings+":/"+_seasons+":/"+_rate+":/"+_platform;
    }
    public override void LoadingData(string[] Data)
    {
        base.LoadingData(Data);
        _seasons = int.Parse(Data[7]);
        _rate = Data[8];
        _platform = Data[9];
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