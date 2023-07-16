// This class will be in charge of collect all the media, and suggestions.
//It will load and save all the information.
public class Collection
{
    List<Media> _media = new List<Media>();
    List <User> _users = new List<User>();
    protected List<Suggestion> _suggestions = new List<Suggestion>();
    protected List<Response> _responses = new List<Response>();

    public void DisplaySuggestions()
    {
        Console.Clear();
        Console.WriteLine("Suggest Media\n");
        for (int i = 0; i < _suggestions.Count; i++)
            {
                Console.Write(i+1 + ". ");
                // Go through every suggestion made and display them.
                _suggestions[i].Display();
                Console.WriteLine($"----------------------------------------------------------------------\n");
            }
    }

    public void SuggestionFilter(string UserName)
    {
        Console.Clear();
        Console.WriteLine("Media suggested to me\n");
        for (int i = 0; i < _suggestions.Count; i++)
            {
                // Verify if the suggestion was requested by user.
                if(_suggestions[i].GetUsername() == UserName){
                    // Go through every suggestion made and display them.
                    _suggestions[i].Display();
                    _suggestions[i].ShowResponses();
                    Console.WriteLine($"\n*******************************************************************\n");
                }
            }
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
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
        // Showing Request and suggestions already given.
        Console.Clear();
        _suggestions[Index-1].Display();
        _suggestions[Index-1].ShowResponses();
        Response newResponse = new Response();
        newResponse.NewResponse(_suggestions[Index-1],_media,_suggestions[Index-1].GetCode(),Collect,Person,MediaCode);
        _responses.Add(newResponse);
        _suggestions[Index-1].AddResponse(newResponse);
        _suggestions[Index-1].Display();
        _suggestions[Index-1].ShowResponses();
        Console.WriteLine($"\nPress enter to continue");
        Console.ReadLine();
    }

    public int LoadMedia()
    {
        int currentCode = 1;
        string[] lines = System.IO.File.ReadAllLines("Media.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(":/");
            if (parts[0] == "Music")
            {
                _media.Add(new Music());
                _media[_media.Count - 1].LoadingData(parts);
                currentCode = _media[_media.Count-1].GetCode();
            }
            else if (parts[0] == "Movie"){
                _media.Add(new Movie());
                _media[_media.Count - 1].LoadingData(parts);
                currentCode = _media[_media.Count-1].GetCode();
            }
            else if (parts[0] == "TvShow"){
                _media.Add(new TvShow());
                _media[_media.Count - 1].LoadingData(parts);
                currentCode = _media[_media.Count-1].GetCode();
            }
        }
        return currentCode;
    }

    public void LoadResponses()
    {
        // Open the Responses file and separate line by line
        string[] lines = System.IO.File.ReadAllLines("Responses.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(":/");
            // Add a new response to the Responses list.
            _responses.Add(new Response());
            // Load info from file to the object response.
            _responses[_responses.Count - 1].LoadingData(parts,_media);
        }
    }

    public void LoadUsers()
    {
        string[] lines = System.IO.File.ReadAllLines("Users.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(":/");
            _users.Add(new User());
            _users[_users.Count-1].LoadInfo(parts);
        }
    }
    public int LoadSuggestions()
    {
        int currentCode = 1;
        string[] lines = System.IO.File.ReadAllLines("Suggestions.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(":/");
            _suggestions.Add(new Suggestion());
            _suggestions[_suggestions.Count - 1].LoadingData(parts,_responses);
            currentCode = _suggestions[_suggestions.Count-1].GetCode();
        }
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

    public void SaveResponses()
    {
        using(StreamWriter outputFile = new StreamWriter("Responses.txt"))
        {
            for (int i = 0; i < _responses.Count; i++)
            {
                outputFile.WriteLine(_responses[i].GetTxtInfo());
            }
        }
    }

    public void SaveUsers()
    {
        using(StreamWriter outputFile = new StreamWriter("Users.txt"))
        {
            for (int i = 0; i < _users.Count; i++)
            {
                outputFile.WriteLine(_users[i].GetTxtInfo());
            }
        }
    }

    public void AddAskedPoint(string Name)
    {
        for(int i = 0; i < _users.Count; i++)
        {
            if (_users[i].GetName() == Name)
            {
                _users[i].AskedPlus();
            }
        }
    }

    public void AddSuggestedPoint(string Name)
    {
        for(int i = 0; i < _users.Count; i++)
        {
            if (_users[i].GetName() == Name)
            {
                _users[i].SuggestedPlus();
            }
        }
    }

    public void DisplayProfile(string Name)
    {
        for(int i = 0; i < _users.Count; i++)
        {
            if (_users[i].GetName() == Name)
            {
                _users[i].DisplayProfile();
            }
        }
    }
}