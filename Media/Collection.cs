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
            }
    }

    public void AddSuggestionToList(Suggestion newItem)
    {
        _suggestions.Add(newItem);
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