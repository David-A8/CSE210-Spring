public class MainMenu
{
    public void Display(User Person)
    {
        Collection collection = new Collection();
        collection.LoadMedia();
        collection.LoadSuggestions();
        string response = "";
        string[] options = {"1","2","3","4"};
        while (response!="4")
        {
            while(options.Contains(response)==false)
            {
                Console.Clear();
                Console.WriteLine("Main Menu:");
                Console.Write("   1. Request a suggestion" +
                "\n   2. Suggest media\n   3. View profile" +
                "\n   4. Quit\n\nSelect a choice from the menu: ");
                response = Console.ReadLine() ?? String.Empty;
            }

            switch(response)
            {
                case "4":
                    collection.SaveMedia();
                    collection.SaveSuggestions();
                    Environment.Exit(0);
                    break;
                case "1":
                    Suggestion newSuggestion = new Suggestion();
                    newSuggestion.NewSuggestion(Person);
                    collection.AddSuggestionToList(newSuggestion);
                    break;
                case "2":
                    collection.DisplaySuggestions();
                    Console.Write($"\nType number of the suggestion you wanna respond to: ");
                    string respond = Console.ReadLine() ?? string.Empty;
                    collection.AddResponse(int.Parse(respond));
                    break;
            }
        response = "";
        }
    }
}