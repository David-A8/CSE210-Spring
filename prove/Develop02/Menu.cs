public class Menu
{
    public Journal _journal;
    private Prompt _tempQuestion;
    private SaveLoad _files;
    
    // Creates a menu for the journal.
    public Menu(Journal journal)
    {
        _journal = journal;
    }

    // Display the options in the menu.
    public void Display()
    {
        string response = "";
        string[] options = {"1","2","3","4","5"};
        while (response!="5")
        {
            while(options.Contains(response)==false)
            {
                Console.Write("Please select one of the following choices:");
                Console.WriteLine("\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
                response = Console.ReadLine() ?? String.Empty;
            }

            switch(response)
            {
                // This option finish the program.
                case "5":
                    Environment.Exit(0);
                    break;
                // This option will add a new entry to the journal.
                case "1":
                    _tempQuestion = new Prompt();
                    Console.WriteLine(_tempQuestion.Display());
                    string answer = Console.ReadLine();
                    _journal.AddEntries(new Entry(DateTime.Now,_tempQuestion,answer));
                    Console.WriteLine("Entry added successfully!");
                    break;
                // This option will display all the entries in a journal.
                case "2":
                    _journal.Display();
                    break;
                // Option to open a journal from a txt file.
                case "3":
                    Console.WriteLine("What is the filename? ");
                    string textFile = Console.ReadLine() ?? string.Empty;
                    _files = new SaveLoad();
                    _files.Load(textFile);
                    break;
                // This option will ask for a filename and save the journal as a txt file.
                case "4":
                    Console.WriteLine("What is the filename? ");
                    string fileName = Console.ReadLine() ?? string.Empty;
                    _files = new SaveLoad();
                    _files.Save(fileName, _journal);
                    Console.WriteLine("File saved successfully");
                    break;
            }
            response = "";
        }
    }
}