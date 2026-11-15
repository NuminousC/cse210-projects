
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a reference for Proverbs 3:5-6.
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        // Store the scripture text.
        string text = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        // Create the Scripture object.
        Scripture scripture = new Scripture(reference, text);

        // EXTRA FEATURE:
        // The program hides two words per round.
        // Change this number to make the memorization challenge
        // easier or more difficult.
        int wordsToHidePerRound = 2;

        // Welcome the user.
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
        Console.WriteLine("Press Enter to begin.");

        Console.ReadLine();

        // Keep running until the user quits or all words are hidden.
        while (true)
        {
            // Clear the previous display.
            Console.Clear();

            // Display the current scripture.
            Console.WriteLine(scripture.GetDisplayText());

            // Check whether all words have been hidden.
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine();
                Console.WriteLine("Congratulations! You have hidden all the words.");
                break;
            }

            // Ask the user what to do next.
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit': ");

            string input = Console.ReadLine();

            // End the program if the user types quit.
            if (input != null && input.Trim().ToLower() == "quit")
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for using the Scripture Memorizer!");
                break;
            }

            // Hide more random words.
            scripture.HideRandomWords(wordsToHidePerRound);
        }
    }
}
