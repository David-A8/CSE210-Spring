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

}