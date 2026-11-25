
using System;
using System.Threading;

public abstract class Activity
{
    // Private member variables shared by all activities.
    private string _name;
    private string _description;
    private int _duration;

    // Constructor initializes the shared activity information.
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    // Returns the duration selected by the user.
    public int GetDuration()
    {
        return _duration;
    }

    // Stores the duration selected by the user.
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // Displays the common starting message.
    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        int duration = 0;
        bool validInput = false;

        while (!validInput)
        {
            Console.Write("How long, in seconds, would you like for your session? ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out duration) && duration > 0)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Please enter a whole number greater than zero.");
            }
        }

        SetDuration(duration);

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(2);
        Console.WriteLine();

        ShowCountDown(3);
        Console.WriteLine();
    }

    // Displays the common ending message.
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(2);

        Console.WriteLine();
        Console.WriteLine(
            $"You have completed {_duration} seconds of the {_name}.");

        ShowSpinner(3);
        Console.WriteLine();
    }

    // Displays a rotating spinner animation.
    public void ShowSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);

            Thread.Sleep(200);

            Console.Write("\b \b");

            index = (index + 1) % spinner.Length;
        }
    }

    // Displays a countdown animation.
    public void ShowCountDown(int seconds)
    {
        for (int number = seconds; number > 0; number--)
        {
            string numberText = number.ToString();

            Console.Write(numberText);
            Thread.Sleep(1000);

            Console.Write(
                new string('\b', numberText.Length) +
                new string(' ', numberText.Length) +
                new string('\b', numberText.Length));
        }
    }
}
