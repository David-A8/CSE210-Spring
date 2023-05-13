public class Menu
{
    public Journal _journal;
    private Prompt _tempQuestion;
    private SaveLoad _files;
    public Menu(Journal journal)
    {
        _journal = journal;
    }

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
                case "5":
                    Environment.Exit(0);
                    break;
                case "1":
                    _tempQuestion = new Prompt();
                    Console.WriteLine(_tempQuestion.Display());
                    string answer = Console.ReadLine();
                    _journal.AddEntries(new Entry(DateTime.Now,_tempQuestion,answer));
                    break;
                case "2":
                    _journal.Display();
                    break;
                case "3":
                    break;
                case "4":
                    Console.WriteLine("What is the filename? ");
                    string fileName = Console.ReadLine();
                    _files = new SaveLoad();
                    _files.Save(fileName, _journal);
                    break;
            }
            response = "";
        }
    }
}