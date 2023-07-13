public class Suggestion
{
    string _type = "";
    string _genre = "";
    string _description = "";
    string _date = "";
    string _userName = "";
    List<Media> _responses = new List<Media>();

    public void NewSuggestion(User Person)
    {
        Console.Clear();
        Boolean loop = true;
        Console.WriteLine("Requesting a Suggestion\n");
        while (loop)
        {
            Console.WriteLine("Pick a type of media: ");
            Console.Write($"\n1.   Music\n2.   Movie\n3.   TV Show\n\nType: ");
            string choice = Console.ReadLine() ?? string.Empty;
            if (choice == "1"){
                Console.Clear();
                Console.WriteLine("Suggestion for Music");
                _type = "Music";
                loop = false;
            }
            else if (choice == "2"){
                Console.Clear();
                Console.WriteLine("Suggestion for Movies");
                _type = "Movie";
                loop = false;
            }
            else if (choice == "3"){
                Console.Clear();
                Console.WriteLine("Suggestion for TV Shows");
                _type = "Tv Show";
                loop = false;
            }
            else{
                Console.WriteLine("No valid choice. Try again.");
            }
        }
        DateTime todayDate = DateTime.Now;
        Console.Write($"\nGenre: ");
        _genre = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Add a comment:");
        _description = Console.ReadLine() ?? string.Empty;
        _date = todayDate.ToShortDateString();
        _userName = Person.GetName();
        Console.WriteLine("\nNew request created successfully");
        Thread.Sleep(2500);
    }

    public void Display()
    {
        Console.Write($"Type: {_type}");
        Console.WriteLine($"\nGenre: {_genre}");
        Console.WriteLine($"Comment: {_description}");
        Console.WriteLine(_userName +" - " + _date);
        Console.WriteLine($"----------------------------------------------------------------------\n");
    }

    public string GetTxtInfo()
    {
        return _type+":/"+_genre+":/"+ _description+":/"+_date+":/"+_userName;
    }

    public void LoadingData(string[] Data)
    {
        _type = Data[0];
        _genre = Data[1];
        _description = Data[2];
        _date = Data[3];
        _userName = Data[4];
    }

}