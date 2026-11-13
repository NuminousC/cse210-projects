
        // Creativity beyond the core requirements:
        // Each journal entry records the user's mood as well as the date,
        // prompt, and written response. The mood summary option helps users
        // reflect on their feelings over time.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        // Creativity beyond the core requirements:
        // Each journal entry records the user's mood as well as the date,
        // prompt, and written response. The mood summary option helps users
        // reflect on their feelings over time.

        while (running)
        {
            Console.WriteLine("\nJOURNAL MENU");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. View mood summary");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Get a random prompt.
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine($"\n{prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                // Prevent the file separator from breaking saved entries.
                response = response.Replace("|", "/");

                // Get the current date.
                string date = DateTime.Now.ToShortDateString();

                // Ask the user how they felt.
                Console.WriteLine("\nHow did you feel today?");
                Console.WriteLine("Examples: Happy, Grateful, Peaceful, Sad, Anxious");
                Console.Write("Your mood: ");
                string mood = Console.ReadLine();

                mood = mood.Replace("|", "/");

                // Create a new Entry object.
                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                newEntry._mood = mood;

                // Add the entry to the journal.
                myJournal.AddEntry(newEntry);

                Console.WriteLine("\nYour entry has been added.");
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename to save to: ");
                string filename = Console.ReadLine();

                myJournal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();

                myJournal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                myJournal.DisplayMoodSummary();
            }
            else if (choice == "6")
            {
                running = false;
                Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose a number from 1 to 6.");
            }
        }
    }
}
