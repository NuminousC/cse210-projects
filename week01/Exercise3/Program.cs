
using System;

class Program
{
    static void Main()
    {
        // Generate a random magic number between 1 and 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // Give the guess an initial value
        int guess = -1;

        // Keep asking until the user guesses correctly
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Your guess is lower. Try a higher number");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Your guess is higher. Try a lower number");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
