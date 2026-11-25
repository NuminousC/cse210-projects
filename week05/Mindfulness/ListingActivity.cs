
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private List<string> _usedPrompts;

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life. You will be given a prompt and asked to list as many responses as you can.")
    {
        _count = 0;

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths you are grateful for?",
            "Who have you helped this week?",
            "What are things that make you happy?",
            "What are challenges you have overcome?",
            "What are things that make you feel grateful?",
            "Who has made a positive difference in your life?"
        };

        _usedPrompts = new List<string>();
    }

    // Runs the listing activity.
    public void Run()
    {
        _count = 0;

        DisplayStartingMessage();

        string prompt = GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine(
            "List as many responses as you can to the following prompt:");

        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();
        Console.WriteLine("You may begin in:");

        ShowCountDown(5);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Start listing your responses.");
        Console.WriteLine("Press Enter after each response.");

        List<string> responses = GetListFromUser();

        Console.WriteLine();
        Console.WriteLine("Time is up!");
        Console.WriteLine($"You listed {_count} item(s).");

        DisplayEndingMessage();
    }

    // Selects a prompt that has not been used in this session.
    public string GetRandomPrompt()
    {
        List<string> availablePrompts = new List<string>();

        foreach (string prompt in _prompts)
        {
            if (!_usedPrompts.Contains(prompt))
            {
                availablePrompts.Add(prompt);
            }
        }

        if (availablePrompts.Count == 0)
        {
            _usedPrompts.Clear();
            availablePrompts = new List<string>(_prompts);
        }

        Random random = new Random();

        int index = random.Next(availablePrompts.Count);

        string selectedPrompt = availablePrompts[index];

        _usedPrompts.Add(selectedPrompt);

        return selectedPrompt;
    }

    // Collects responses while the activity timer is running.
    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();

        string currentResponse = "";

        Stopwatch stopwatch = Stopwatch.StartNew();

        double duration = GetDuration();

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                {
                    if (currentResponse.Trim() != "")
                    {
                        responses.Add(currentResponse.Trim());
                        _count++;

                        Console.WriteLine();
                    }

                    currentResponse = "";
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (currentResponse.Length > 0)
                    {
                        currentResponse = currentResponse.Substring(
                            0, currentResponse.Length - 1);

                        Console.Write("\b \b");
                    }
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    currentResponse += key.KeyChar;
                    Console.Write(key.KeyChar);
                }
            }
            else
            {
                Thread.Sleep(50);
            }
        }

        // Save the final response if the user was still typing when time ended.
        if (currentResponse.Trim() != "")
        {
            responses.Add(currentResponse.Trim());
            _count++;
            Console.WriteLine();
        }

        return responses;
    }
}
