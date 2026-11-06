
using System;

class Program
{
    static void Main()
    {
        // Display the welcome message
        DisplayWelcome();

        // Ask for the user's name
        string name = PromptUserName();

        // Ask for the user's favorite number
        int number = PromptUserNumber();

        // Calculate the square of the number
        int square = SquareNumber(number);

        // Display the result
        DisplayResult(name, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());





        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
