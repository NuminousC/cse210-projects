
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        bool breatheIn = true;

        while (DateTime.Now < endTime)
        {
            int remaining = (int)Math.Ceiling(
                (endTime - DateTime.Now).TotalSeconds);

            int interval = Math.Min(5, remaining);

            if (breatheIn)
            {
                Console.Write("Breathe in...");
            }
            else
            {
                Console.Write("Breathe out...");
            }

            ShowCountDown(interval);

            Console.WriteLine();

            breatheIn = !breatheIn;
        }

        DisplayEndingMessage();
    }
}
