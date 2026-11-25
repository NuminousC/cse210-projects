
using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    // Private lists containing reflection prompts and questions.
    private List<string> _prompts;
    private List<string> _questions;

    // These lists track prompts and questions already used.
    private List<string> _usedPrompts;
    private List<string> _usedQuestions;

    public ReflectingActivity()
        : base(
            "Reflecting Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. Think deeply about the experience and consider what you can learn from it.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you learned something important from a mistake.",
            "Think of a time when you felt the presence of goodness in your life."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "What did you learn about yourself?",
            "How did you feel during this experience?",
            "What made this experience difficult or important?",
            "How can you use what you learned in the future?",
            "Who else was affected by what happened?",
            "What personal strengths did you demonstrate?"
        };

        _usedPrompts = new List<string>();
        _usedQuestions = new List<string>();
    }

    // Runs the reflection activity.
    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();

        DisplayPrompt();

        DisplayQuestions();

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

    // Selects a question that has not been used in this session.
    public string GetRandomQuestion()
    {
        List<string> availableQuestions = new List<string>();

        foreach (string question in _questions)
        {
            if (!_usedQuestions.Contains(question))
            {
                availableQuestions.Add(question);
            }
        }

        if (availableQuestions.Count == 0)
        {
            _usedQuestions.Clear();
            availableQuestions = new List<string>(_questions);
        }

        Random random = new Random();

        int index = random.Next(availableQuestions.Count);

        string selectedQuestion = availableQuestions[index];

        _usedQuestions.Add(selectedQuestion);

        return selectedQuestion;
    }

    // Displays the selected reflection prompt.
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine(
            "When you have something in mind, press Enter to continue.");

        Console.ReadLine();
    }

    // Displays reflection questions until the duration expires.
    public void DisplayQuestions()
    {
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine(GetRandomQuestion());

            int remaining = (int)Math.Ceiling(
                (endTime - DateTime.Now).TotalSeconds);

            int pause = Math.Min(8, remaining);

            ShowSpinner(pause);
        }
    }
}
