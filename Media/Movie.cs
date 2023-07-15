public class Movie : Media
{
    string _director = "";
    string _rate = "";

    public override void NewMedia(int MediaCode)
    {
        _type = "Movie";
        Console.WriteLine("New movie");
        base.NewMedia(MediaCode);
        Console.Write($"\nDirector: ");
        _director = Console.ReadLine() ?? string.Empty;
    }
    public override string GetTxtInfo()
    {
        return "TvShow:/"+_mediaCode+":/"+_title+":/"+_genre+":/"+ _year+":/"+_calification+":/"+_numberRatings+":/"+_director+":/"+_rate;
    }
    public override void LoadingData(string[] Data)
    {
        base.LoadingData(Data);
        _director = Data[7];
        _rate = Data[8];
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Director: {_director}");
        Console.WriteLine($"Rate: {_rate}");
        Console.WriteLine($"Calification: {_calification}");
    }
}