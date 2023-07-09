public class Menu
{
    public void Display()
    {
        string response = "";
        string[] options = {"1","2","3"};
        while (response!="3")
        {
            while(options.Contains(response)==false)
            {
                Console.Clear();
                Console.WriteLine("\nMenu options:");
                Console.Write("   1. Sign in" +
                "\n   2. Create new user\n   3. Quit" +
                "\n\nSelect a choice from the menu: ");
                response = Console.ReadLine() ?? String.Empty;
            }

            switch(response)
            {
                case "3":
                    Environment.Exit(0);
                    break;
                case "1":
                    Boolean verified = false;
                    while (verified == false)
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
                                verified = true;
                                Thread.Sleep(2500);
                                MainMenu menu1 = new MainMenu();
                                menu1.Display();
                                break;
                            }
                        }
                        if (verified == false)
                        {
                            Console.WriteLine("Username or Password invalid... Try again");
                            Thread.Sleep(2500);
                        }
                    }
                    break;
                case "2":
                    User person1 = new User();
                    person1.NewUser();
                    break;
            }
            response = "";
        }
    }
}
