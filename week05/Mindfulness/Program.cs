
using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        // Creativity improvement:
        // The program provides input validation so users cannot
        // accidentally select an invalid activity.

        while (choice != "4")
        {
            Console.Clear();

            Console.WriteLine("==============================");
            Console.WriteLine("      MINDFULNESS PROGRAM");
            Console.WriteLine("==============================");

            Console.WriteLine();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine();

            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.WriteLine();

            choice = GetActivityChoice();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();

                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();

                activity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();

                activity.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine();
                Console.WriteLine(
                    "Thank you for using the Mindfulness Program.");

                Console.WriteLine("Take care of yourself. Goodbye!");
            }

            if (choice != "4")
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the main menu.");
                Console.ReadLine();
            }
        }
    }

    // Gets and validates the user's menu selection.
    static string GetActivityChoice()
    {
        string choice = "";

        bool validChoice = false;

        while (!validChoice)
        {
            Console.Write("Enter your choice (1-4): ");

            choice = Console.ReadLine();

            if (choice == "1" ||
                choice == "2" ||
                choice == "3" ||
                choice == "4")
            {
                validChoice = true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(
                    "Invalid choice. Please select 1, 2, 3, or 4.");

                Console.WriteLine();
            }
        }

        return choice;
    }
}

/*
 * CREATIVITY AND ADDITIONAL FEATURES
 *
 * This program goes beyond the core requirements in the following ways:
 *
 * 1. Non-repeating reflection questions:
 *    Reflection questions are not repeated until all available
 *    questions have been used during the session.
 *
 * 2. Non-repeating activity prompts:
 *    Listing and reflection prompts are selected without repetition
 *    until all available prompts have been used.
 *
 * 3. Timed listing input:
 *    The Listing Activity uses a Stopwatch and keyboard input
 *    monitoring to prevent the user from continuing indefinitely
 *    after the selected duration.
 *
 * 4. Input validation:
 *    The program checks menu selections and activity durations
 *    to prevent invalid entries.
 *
 * 5. Improved user experience:
 *    Countdown and spinner animations guide users through the
 *    activities and pauses.
 */
