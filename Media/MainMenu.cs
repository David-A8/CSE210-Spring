public class MainMenu
{
    public void Display(User Person)
    {
        Collection collection = new Collection();
        int mediaCode = collection.LoadMedia();
        int codeCounter = collection.LoadSuggestions();
        string response = "";
        string[] options = {"1","2","3","4"};
        while (response!="4")
        {
            while(options.Contains(response)==false)
            {
                Console.Clear();
                Console.WriteLine("Main Menu:");
                Console.Write("   1. Request a suggestion" +
                "\n   2. Respond to suggestions\n   3. View Media suggested to me" +
                "\n   4. View profile\n   5. Quit\n\nSelect a choice from the menu: ");
                response = Console.ReadLine() ?? String.Empty;
            }

            switch(response)
            {
                case "5":
                    collection.SaveMedia();
                    collection.SaveSuggestions();
                    Environment.Exit(0);
                    break;
                case "1":
                    Person.AskedPlus();
                    Suggestion newSuggestion = new Suggestion();
                    codeCounter ++;
                    newSuggestion.NewSuggestion(Person, codeCounter);
                    collection.AddSuggestionToList(newSuggestion);
                    break;
                case "2":
                    Person.SuggestedPlus();
                    collection.DisplaySuggestions();
                    Console.Write($"\nType number of the suggestion you wanna respond to: ");
                    string respond = Console.ReadLine() ?? string.Empty;
                    mediaCode ++;
                    collection.AddResponse(int.Parse(respond),collection,Person,mediaCode);
                    break;
                case "3":
                    collection.SuggestionFilter(Person.GetName());
                    break;
                case "4":

                    break;
            }
        response = "";
        }
    }
}