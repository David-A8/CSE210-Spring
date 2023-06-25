public class Menu
{
    public void Display()
    {
        string response = "";
        string[] options = {"1","2","3","4","5","6"};
        Goals goals = new Goals();
        string FileName = "";
        while (response!="6")
        {
            while(options.Contains(response)==false)
            {
                Console.Clear();
                Console.Write("Menu options:");
                Console.Write("\n   1. Create New Goal" +
                "\n   2. List Goals\n   3. Save Goals" +
                "\n   4. Load Goals\n   5. Record Event" +
                "\n   6. Quit \n\nSelect a choice from the menu: ");
                response = Console.ReadLine() ?? String.Empty;
            }

            switch(response)
            {
                case "6":
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.Clear();
                    Console.Write($"The types of Goals are: \n1. Simple Goal" +
                    "\n2. Eternal Goal \n3. Checklist Goal \nWhat type of goal would you like to create?: ");
                    string goalType = Console.ReadLine();
                    if (goalType == "1")
                    {
                        goals.AddGoal(new SimpleGoal());
                    }
                    else if (goalType == "2")
                    {
                        goals.AddGoal(new EternalGoal());
                    }
                    else if (goalType == "3")
                    {
                        goals.AddGoal(new ChecklistGoal());
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid option");
                        Thread.Sleep(2000);
                        break;
                    }
                    Goal newGoal = goals.LastGoal();
                    newGoal.GetName();
                    newGoal.GetDescription();
                    newGoal.GetPoints();
                    break;
                case "2":
                    goals.DisplayGoals();
                    break;
                case "3":
                    Console.Write($"\nWhat is the name for the file?: ");
                    FileName = Console.ReadLine() ?? String.Empty;
                    goals.SaveFile(FileName);
                    break;
                case "4":
                    Console.Write($"\nWhat is the name for the file?: ");
                    FileName = Console.ReadLine() ?? String.Empty;
                    goals.LoadFile(FileName);
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("The goals are: ");
                    
                    break;
            }
            response = "";
        }
    }
}