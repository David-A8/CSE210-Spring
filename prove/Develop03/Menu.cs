public class Menu
{
    public void Display()
    {
        string response = "";
        string[] options = {"1","2","3"};
        Scripture Scripture;
        Console.Write("Please select one of the following choices:");
        Console.WriteLine("\n1. Enter scripture\n2. Use system's scripture\n3. Quit\nWhat would you like to do? ");
        response = Console.ReadLine() ?? String.Empty;

        switch(response)
        {
            case "3":
                Environment.Exit(0);
                break;
            // This option will add a new entry to the journal.
            case "1":
                Console.Clear();
                Console.WriteLine("Enter Book: ");
                string Book = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Enter Chapter: ");
                string Chapter = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Enter Verse: ");
                string Verse = Console.ReadLine () ?? string.Empty;
                Console.WriteLine("Please enter Passage: ");
                string Passage = Console.ReadLine() ?? string.Empty;
                Scripture = new Scripture(Passage,Book,int.Parse(Chapter),int.Parse(Verse));
                Scripture.Display();
                Scripture.RandomHide();
                break;
            // This option will display all the entries in a journal.
            case "2":
                Scripture = new Scripture("And if men come unto me I will show unto them their weakness.\n" +
                "I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me;\n" +
                "for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.", "Ether",12,27);
                Scripture.Display();
                Scripture.RandomHide();
                break;
        }
    }
}