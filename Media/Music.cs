public class Music : Media
{
    string _artist = "";
    string _album = "";

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
}