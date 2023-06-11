public class Menu
{
    public void Display()
    {
        string response = "";
        string[] options = {"1","2","3","4"};
        while (response!="4")
        {
            while(options.Contains(response)==false)
            {
                Console.Clear();
                Console.Write("Menu options:");
                Console.WriteLine("\n   1. Start breathing Activity" +
                "\n   2. Start reflecting activity\n   3. Start listing activity" +
                "\n   4. Quit \nSelect a choice from the menu: ");
                response = Console.ReadLine() ?? String.Empty;
            }

            switch(response)
            {
                // This option finish the program.
                case "4":
                    Environment.Exit(0);
                    break;
                // This option will call the breathing activity.
                case "1":
                    Breathing breath = new Breathing("Breathing Activity","This activity will help you " +
                    "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
                    breath.StartingMessage();
                    breath.StartBreathing();
                    breath.EndingMessage();
                    break;
                // This option will call the reflecting activity.
                case "2":
                    Reflection reflecting = new Reflection("Reflecting Activity","This activity will help you " +
                    "reflect on times in your life when you have shown strength and resilience. This will " +
                    "help you recognize the power you have and how you can use it in other aspects of your life");
                    reflecting.StartingMessage();
                    reflecting.StartReflection();
                    reflecting.EndingMessage();
                    break;
                // Option to call the listing activity.
                case "3":
                    Listing list = new Listing("Listing Activity","This activity will help you reflect on " +
                    "the good things in your life by having you list as many things as you can in a certain area");
                    list.StartingMessage();
                    list.StartListing();
                    list.EndingMessage();
                    break;
            }
            response = "";
        }
    }
}