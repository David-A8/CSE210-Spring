public class Movie : Media
{
    string _director = "";
    string _rate = "";

    public override string GetTxtInfo()
    {
        return "TvShow:/"+_title+":/"+_genre+":/"+ _year+":/"+_calification+":/"+_numberRatings+":/"+_director+":/"+_rate;
    }
    public override void LoadingData(string[] Data)
    {
        base.LoadingData(Data);
        _director = Data[6];
        _rate = Data[7];
    }
}