public class MainMenu
{
    public void Display()
    {
        MediaCollection collection = new MediaCollection();
        collection.LoadMedia();
        string response = "";
        string[] options = {"1","2","3","4"};
        while (response!="4")
        {
            while(options.Contains(response)==false)
            {
                Console.Clear();
                Console.WriteLine("Main Menu:");
                Console.Write("   1. New suggestion" +
                "\n   2. Make a suggestion\n   3. View profile" +
                "\n   4. Quit\n\nSelect a choice from the menu: ");
                response = Console.ReadLine() ?? String.Empty;
            }

            switch(response)
            {
                case "4":
                    collection.SaveMedia();
                    Environment.Exit(0);
                    break;
                case "1":
                    Suggestion newSuggestion = new Suggestion();
                    newSuggestion.NewSuggestion("user1");
                    break;
            }
        response = "";
        }
    }
}