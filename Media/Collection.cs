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

    public void AddMedia(Media newItem)
    {
        _media.Add(newItem);
    }

    // Method to add responses to suggestions.
    public void AddResponse(int Index, Collection Collect, User Person,int MediaCode)
    {
        // Showing Request and responses already given.
        Console.Clear();
        _suggestions[Index-1].Display();
        _suggestions[Index-1].ShowResponses();
        Response newResponse = new Response();
        newResponse.NewResponse(_suggestions[Index-1],_media,_suggestions[Index-1].GetCode(),Collect,Person,MediaCode);
        _suggestions[Index-1].AddResponse(newResponse);
        _suggestions[Index-1].Display();
        _suggestions[Index-1].ShowResponses();
        Console.WriteLine($"\nPress enter to continue");
        Console.ReadLine();
    }

    public int LoadMedia()
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
        int currentCode = _media[_media.Count-1].GetCode();
        return currentCode;
    }

    public int LoadSuggestions()
    {
        string[] lines = System.IO.File.ReadAllLines("Suggestions.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(":/");
            _suggestions.Add(new Suggestion());
            _suggestions[_suggestions.Count - 1].LoadingData(parts);
        }
        int currentCode = _suggestions[_suggestions.Count-1].GetCode();
        return currentCode;
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