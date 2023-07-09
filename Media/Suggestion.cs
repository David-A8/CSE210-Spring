public class Suggestion
{
    string _type = "";
    string _genre = "";
    string _description = "";
    string _date = "";
    string _user = "";
    List<Media> _responses = new List<Media>();

    public void NewSuggestion(string user)
    {
        Console.Clear();
        Boolean loop = true;
        Console.WriteLine("New Suggestion");
        while (loop)
        {
            Console.WriteLine(" What type of media do you want?");
            Console.Write($"\n1.   Music\n2.   Movie\n3.   TV Show\nEnter Type: ");
            string choice = Console.ReadLine() ?? string.Empty;
            if (choice == "1"){
                Console.WriteLine("Music");
                loop = false;
            }
            else if (choice == "2"){
                Console.WriteLine("Movie");
                loop = false;
            }
            else if (choice == "3"){
                Console.WriteLine("TV Show");
                loop = false;
            }
            else{
                Console.WriteLine("No valid choice. Try again.");
            }
        }
        Console.WriteLine("Suggestion was created successfully");
        Thread.Sleep(2500);
    }

}