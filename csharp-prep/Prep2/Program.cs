using System;

class Program
{
    static void Main(string[] args)
    {
Console.WriteLine("What is your grade percentage?: ");
        string percentageStr = Console.ReadLine();
        int percentage = int.Parse(percentageStr);
        string letter = "invalid";
        if (percentage >= 90 && percentage <= 100)
        {
            letter = "A";
        }
        else if (percentage >= 80 && percentage < 90)
        {
            letter = "B";
        }
        else if (percentage >= 70 && percentage < 80)
        {
            letter = "C";
        }
        else if (percentage >= 60 && percentage < 70)
        {
            letter = "D";
        }
        else if (percentage < 60 && percentage >=0)
        {
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is {letter}");
        if (percentage > 70 && percentage <=100)
        {
            Console.WriteLine("Congratulations!!! You passed the class.");
        }
        else if (percentage < 70 && percentage >= 0)
        {
            Console.WriteLine("I'm sorry, you didn't pass the class. Try better for next time.");
        }
    }
}