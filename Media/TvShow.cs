public class TvShow : Media
{
    int _seasons;
    string _rate = "";
    string _platform = "";

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
}