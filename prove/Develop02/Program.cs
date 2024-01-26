using System;
using System.Collections.Generic;
using System.IO;

class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public JournalEntry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"{Date} - {Prompt}\n{Response}\n";
    }
}

class Journal
{
    private List<JournalEntry> entries;

    public Journal()
    {
        entries = new List<JournalEntry>();
    }

    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        entries.Clear(); 

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string[] parts = reader.ReadLine().Split('|');
                    if (parts.Length == 3)
                    {
                        entries.Add(new JournalEntry(parts[1], parts[2], parts[0]));
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
    }
}

class Program
{
    static Journal journal = new Journal();

    static void Main()
    {
        while (true)
        {
            DisplayMenu();
            string choice = GetUserChoice();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;

                case "2":
                    DisplayJournal();
                    break;

                case "3":
                    SaveJournalToFile();
                    break;

                case "4":
                    LoadJournalFromFile();
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
    }

    static string GetUserChoice()
    {
        Console.Write("Choose an option (1-5): ");
        return Console.ReadLine();
    }

    static void WriteNewEntry()
    {
        Console.WriteLine("Choose a prompt:");
        DisplayPrompts();

        int promptNumber = GetUserInputAsNumber("Enter the number of the prompt: ");
        string response = GetUserInput("Enter your response: ");
        string prompt = GetPromptByNumber(promptNumber);
        string date = DateTime.Now.ToString("yyyy-MM-dd");

        JournalEntry newEntry = new JournalEntry(prompt, response, date);
        journal.AddEntry(newEntry);
    }

    static void DisplayPrompts()
    {
        Console.WriteLine("1. Who was the most interesting person I interacted with today?");
        Console.WriteLine("2. What was the best part of my day?");
        Console.WriteLine("3. How did I see the hand of the Lord in my life today?");
        Console.WriteLine("4. What was the strongest emotion I felt today?");
        Console.WriteLine("5. If I had one thing I could do over today, what would it be?");
    }

    static int GetUserInputAsNumber(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }

    static string GetUserInput(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }

    static void DisplayJournal()
    {
        Console.WriteLine("Journal Entries:");
        journal.DisplayEntries();
    }

    static void SaveJournalToFile()
    {
        string fileName = GetUserInput("Enter the file name to save the journal: ");
        journal.SaveToFile(fileName);
    }

    static void LoadJournalFromFile()
    {
        string fileName = GetUserInput("Enter the file name to load the journal: ");
        journal.LoadFromFile(fileName);
    }

    static string GetPromptByNumber(int number)
    {
        switch (number)
        {
            case 1: return "Who was the most interesting person I interacted with today?";
            case 2: return "What was the best part of my day?";
            case 3: return "How did I see the hand of the Lord in my life today?";
            case 4: return "What was the strongest emotion I felt today?";
            case 5: return "If I had one thing I could do over today, what would it be?";
            default: return "Unknown prompt";
        }
    }
}
