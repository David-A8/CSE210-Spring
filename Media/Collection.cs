// This class will be in charge of collect all the media, and suggestions.
//It will load and save all the information.
public class Collection
{
    List<Media> _media = new List<Media>();
    protected List<Suggestion> _suggestions = new List<Suggestion>();

    public void DisplaySuggestions()
    {
        Console.Clear();
        Console.WriteLine("Suggest Media\n");
        for (int i = 0; i < _suggestions.Count; i++)
            {
                Console.Write(i+1 + ". ");
                // Go through every suggestion made and display it.
                _suggestions[i].Display();
                Console.WriteLine($"----------------------------------------------------------------------\n");
            }
    }

    public void AddSuggestionToList(Suggestion newItem)
    {
        _suggestions.Add(newItem);
    }

    // Method to add responses to suggestions.
    public void AddResponse(int Index)
    {
        // Showing Request and responses already given.
        Console.Clear();
        _suggestions[Index-1].Display();
        _suggestions[Index-1].ShowResponses();
        Boolean Found = false;
        string Type = _suggestions[Index -1].Type();
        Console.Write($"\n\nEnter details of {Type}\n\nEnter title: ");
        string Title = Console.ReadLine() ?? string.Empty;
        Console.Write($"\nYear of release: ");
        int Year = int.Parse(Console.ReadLine() ?? string.Empty);
        for (int i = 0; i < _media.Count; i++)
        {
            if (_media[i].Type() == Type){
                if (_media[i].Title().ToUpper() == Title.ToUpper()){
                    if (_media[i].Year() == Year){
                        _suggestions[Index-1].AddResponse(_media[i]);
                        _media[i].ShowInfo();
                        Found = true;
                    }
                }
            }
        }
        if (Found == false){
            Console.WriteLine($"The {Type} was not found. Please enter the info to create a new entry.");
            if (Type == "Music"){
                _media.Add (new Music());
            }
            else if (Type == "Movie"){
                _media.Add (new Movie());
            }
            else if(Type == "TvShow"){
                _media.Add(new TvShow());
            }
            _media[_media.Count-1].NewMedia();
            _suggestions[Index-1].AddResponse(_media[_media.Count-1]);
            Console.WriteLine("New entry added. Thank you for your response!!");
            Thread.Sleep(2500);
            Console.Clear();
            _suggestions[Index-1].Display();
            _suggestions[Index-1].ShowResponses();
            Console.WriteLine($"\nPress enter to continue");
            Console.ReadLine();
        }
    }

    public void LoadMedia()
    {
        string[] lines = System.IO.File.ReadAllLines("Media.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(":/");
            if (parts[0] == "Music")
            {
                _media.Add(new Music());
            }
            else if (parts[0] == "Movie"){
                _media.Add(new Movie());
            }
            else if (parts[0] == "TvShow"){
                _media.Add(new TvShow());
            }
            _media[_media.Count - 1].LoadingData(parts);
        }
    }

    public void LoadSuggestions()
    {
        string[] lines = System.IO.File.ReadAllLines("Suggestions.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(":/");
            _suggestions.Add(new Suggestion());
            _suggestions[_suggestions.Count - 1].LoadingData(parts);
        }
    }
    
    public void SaveMedia()
    {
        using(StreamWriter outputFile = new StreamWriter("Media.txt"))
        {
            for (int i = 0; i < _media.Count; i++)
            {
                outputFile.WriteLine(_media[i].GetTxtInfo());
            }
        }
    }

    public void SaveSuggestions()
    {
        using(StreamWriter outputFile = new StreamWriter("Suggestions.txt"))
        {
            for (int i = 0; i < _suggestions.Count; i++)
            {
                outputFile.WriteLine(_suggestions[i].GetTxtInfo());
            }
        }
    }
}