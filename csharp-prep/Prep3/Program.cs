using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int numberGuess = 0;
        int guessesCounter = 0;
        while (numberGuess != number)
        {
            Console.WriteLine();
            Console.Write("What is your guess? ");
            string numberGuessStr = Console.ReadLine();
            numberGuess = int.Parse(numberGuessStr);
            if (numberGuess < number)
            {
                Console.WriteLine("Number is too low");
            }
            if (numberGuess > number)
            {
                Console.WriteLine("Number is too high");
            }
            guessesCounter += 1;
        }
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"You made {guessesCounter} guesses.");


    }
}