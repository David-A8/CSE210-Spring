public class Menu
{
    public User person1 = new User();

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
                        verified = person1.SignIn(person1);
                    }
                    break;

                case "2":
                    person1.NewUser();
                    break;
            }
            response = "";
        }
    }
}
