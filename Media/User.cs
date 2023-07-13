public class User
{
    string _name = "";
    string _lastName = "";
    string _password = "";
    int _timesAsked = 0;
    int _timesSuggested = 0;
    string _category = "";

    public void NewUser()
    {
        Console.Clear();
        Console.WriteLine("Create New User");
        while (_name == ""){
            Console.Write($"\n  First Name: ");
            _name = Console.ReadLine() ?? string.Empty;
            if (_name == ""){
                Console.WriteLine("The field is empty, please try again.");
            }
        }
        while (_lastName == ""){
            Console.Write($"\n  Last Name: ");
            _lastName = Console.ReadLine() ?? string.Empty;
            if (_lastName == ""){
                Console.WriteLine("The field is empty, please try again.");
            }
        }

        while (_password == ""){
            Console.Write($"\n  Create a password: ");
            _password = Console.ReadLine() ?? string.Empty;
            if (_password == ""){
                Console.WriteLine("The field is empty, please try again.");
            }
        }

        using(StreamWriter outputFile = new StreamWriter("Users.txt"))
        {
            outputFile.WriteLine($"{_name}:/{_lastName}:/{_password}:/{_timesAsked}:/{_timesSuggested}:/{_category}");
        }
        Console.Write($"\n\nUser created successfully!!!");
        Thread.Sleep(2500);
    }

    public Boolean SignIn(User person)
    {
        Console.Clear();
        Console.WriteLine("Sign In");
        Console.Write($"\n  Username (First and Last Name): ");
        string userName = Console.ReadLine() ?? string.Empty;
        Console.Write($"  Password: ");
        string password = Console.ReadLine() ?? string.Empty;
        string[] lines = System.IO.File.ReadAllLines("Users.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(":/");
            string userFile = parts[0] + " " + parts[1];
            string passwordFile = parts[2];
            if (userFile == userName && passwordFile == password)
            {
                Console.WriteLine($"\nWelcome {userName}!!!");
                Thread.Sleep(2500);
                _name = parts[0];
                _lastName = parts[1];
                _password = parts[2];
                _timesAsked = int.Parse(parts[3]);
                _timesSuggested = int.Parse(parts[4]);
                _category = parts[5];
                MainMenu mainMenu = new MainMenu();
                mainMenu.Display(person);
                return true;
            }
        }
            Console.WriteLine("Username or Password invalid... Try again");
            Thread.Sleep(2500);
            return false;
    }

    public string GetName()
    {
        return _name + " " + _lastName;
    }
}