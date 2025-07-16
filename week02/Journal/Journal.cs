using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddNewEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAllEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty... But that is easy to fix! Let's add some entries!");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptIdea}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile()
    {
        Console.Write("Enter the filename you want to load from: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _entries.Clear(); 
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string entryText = parts[2];
                    Entry newEntry = new Entry(date, prompt, entryText);
                    _entries.Add(newEntry);
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine($"The file '{filename}' was not found...");
        }
    }
}