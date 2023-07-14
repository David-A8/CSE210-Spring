public class Music : Media
{
    string _artist = "";
    string _album = "";

    public override void NewMedia()
    {
        _type = "Music";
        Console.WriteLine("New Song");
        base.NewMedia();
        Console.Write($"\nArtist: ");
        _artist = Console.ReadLine() ?? string.Empty;
        Console.Write($"\nAlbum: ");
        _album = Console.ReadLine() ?? string.Empty;
    }
    public override string GetTxtInfo()
    {
        return "Music:/" + _title +":/" + _genre +":/" + _year +":/" + _calification +":/" + _numberRatings + ":/" + _artist +":/"+ _album;
    }
    public override void LoadingData(string[] Data)
    {
        base.LoadingData(Data);
        _artist = Data[6];
        _album = Data[7];
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Artist: {_artist}");
        Console.WriteLine($"Album: {_album}");
        Console.WriteLine($"Calification: {_calification}");
    }
}