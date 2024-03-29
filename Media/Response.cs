public class Response
{
    int _code = 0;
    List <Media> _media = new List<Media>();
    string _comment = "";
    string _userName = "";
    string _date = "";


    // Method to create a new response.
    public void NewResponse(Suggestion sugg, List<Media> Media, int Code, Collection Collection, User Person, int MediaCode)
    {
        _code = Code;
        Boolean Found = false;
        string Type = sugg.Type();
        Console.WriteLine($"\n\nNew suggestion");
        // First, the program will verify if the Media is already in the List of Media.
        Console.Write($"\nEnter details of {Type}\n\nEnter title: ");
        string Title = Console.ReadLine() ?? string.Empty;
        Console.Write($"Year of release: ");
        int Year = int.Parse(Console.ReadLine() ?? string.Empty);
        for (int i = 0; i < Media.Count; i++)
        {
            if (Media[i].Type() == Type){
                if (Media[i].Title().ToUpper() == Title.ToUpper()){
                    // If media is found, it will be displayed.
                    if (Media[i].Year() == Year){
                        _media.Add (Media[i]);
                        Media[i].ShowInfo();
                        Found = true;
                    }
                }
            }
        }
        // If media is not found. A new object will be created.
        if (Found == false){
            Console.WriteLine($"\n{Type} not found. Please enter the info to create a new entry.\n");
            if (Type == "Music"){
                Music newItem = (new Music());
                newItem.NewMedia(MediaCode);
                Collection.AddMedia(newItem);
                _media.Add (newItem);
            }
            else if (Type == "Movie"){
                Movie newItem = (new Movie());
                newItem.NewMedia(MediaCode);
                Collection.AddMedia(newItem);
                _media.Add (newItem);
            }
            else if(Type == "TvShow"){
                TvShow newItem = (new TvShow());
                newItem.NewMedia(MediaCode);
                Collection.AddMedia(newItem);
                _media.Add (newItem);
            }
        }
        //After the media was found or created. The rest of the fields for the suggestion are filled.
        DateTime todayDate = DateTime.Now;
        Console.WriteLine($"\nAdd a comment to your suggestion:");
        _comment = Console.ReadLine() ?? string.Empty;
        _date = todayDate.ToShortDateString();
        _userName = Person.GetName();
        Console.WriteLine("\nThank you for your suggestion!!!");
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void DisplayResponse()
    {
        _media[0].ShowInfo();
        Console.WriteLine($"Comment: {_comment}");
        Console.WriteLine(_userName +" - " + _date);
    }

    public string GetTxtInfo()
    {
        return _code+":/"+_media[0].Type()+":/"+ _media[0].Title()+":/"+_media[0].Year()+":/"+_comment+":/"+_userName+":/"+_date;
    }

    public int GetCode()
    {
        return _code;
    }

    public void LoadingData(string[] Data, List<Media> Media)
    {
        _code = int.Parse(Data[0]);
        for (int i = 0; i < Media.Count; i++)
        {
            if (Media[i].Type() == Data[1]){
                if (Media[i].Title().ToUpper() == Data[2].ToUpper()){
                    // If media is found, it will be saved in the response.
                    if (Media[i].Year() == int.Parse(Data[3])){
                        _media.Add (Media[i]);
                    }
                }
            }
        }
        _comment = Data[4];
        _userName = Data[5];
        _date = Data[6];
    }
}