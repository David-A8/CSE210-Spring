public abstract class Media
{
    protected string _title = "";
    protected string _genre = "";
    protected int _year;
    protected int _calification;
    protected int _numberRatings;

    public void NewMedia()
    {
        Console.WriteLine("Enter Title: ");
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