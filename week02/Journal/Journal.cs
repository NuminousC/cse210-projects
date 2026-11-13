
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.GetFileData());
            }
        }

        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);

            _entries.Clear();

            foreach (string line in lines)
            {
                if (line != "")
                {
                    Entry entry = new Entry();
                    entry.SetFileData(line);
                    _entries.Add(entry);
                }
            }

            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found. Please check the filename.");
        }
    }

    public void DisplayMoodSummary()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("There are no entries to summarize.");
            return;
        }

        Console.WriteLine("\nMOOD SUMMARY");

        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"{entry._date}: {entry._mood}");
        }
    }
}
