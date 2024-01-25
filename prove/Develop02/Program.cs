using System;

class JournalEntry
{
    public string _date;
    public string _content;
    public string _prompt;

    public JournalEntry(string date, string content, string prompt)
    {
        _date = date;
        _content = content;
        _prompt = prompt;
    }
}
class Journal
{
    public List<JournalEntry> entries = new List<JournalEntry>();

    public static string GeneratePrompt()
    {
        List<string> prompts = new List<string>
        {
            "Describe a memorable moment from today that brought you joy.",
            "What was the most challenging aspect of your day and how did you overcome it?",
            "Reflect on a person who inspired you today and the reasons behind it.",
            "Share a goal you accomplished today and how it made you feel.",
            "Write about a new skill or knowledge you gained today.",
            "Describe a place you visited or an activity you enjoyed today.",
            "Discuss a decision you made today and its impact on your day.",
            "Reflect on a hobbie or song that left an impression on you recently.",
            "Write about a conversation you had today that made you think or feel deeply.",
            "Share a moment of gratitude for something or someone in your life."
        };

        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        string randomPrompt = prompts[randomIndex];

        return randomPrompt;
    }
    public void AddEntry()
    {
        string prompt = GeneratePrompt();

        Console.WriteLine("Today's prompt:");
        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.WriteLine("Type in the field bellow");

        string userEntry = Console.ReadLine();

        Console.Write("Do you want to store this entry?[y/n] ");
        string userInput = Console.ReadLine();

        DateTime currentDate = DateTime.Now;
        string formattedDate = currentDate.ToString("MM/dd/yyy - HH:mm");

        if (userInput == "y")
        {
            JournalEntry entry1 = new JournalEntry(formattedDate, userEntry, prompt);
            entries.Add(entry1);
        }
    }

    public void DisplayEntries()
    {
        if (entries.Count > 0)
        {
            foreach (var entry in entries)
            {
                Console.WriteLine();
                Console.WriteLine(entry._date);
                Console.WriteLine("----------------------");
                Console.WriteLine(entry._content);
                Console.WriteLine($"Prompt -> ''{entry._prompt}''");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("There are no entries.");
        }
        
    }

    public void SaveToFile(List<JournalEntry> entries, string fileName)
    {
        string currentDirectory = Environment.CurrentDirectory;
        string fullFilePath = Path.Combine(currentDirectory,  "Journal", fileName);
        
        if (!Directory.Exists(Path.GetDirectoryName(fullFilePath)))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(fullFilePath));
        }
        using (StreamWriter writer = new StreamWriter(fullFilePath))
        {
            // Check if there are entries before writing to the file
            if (entries.Count > 0)
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry._date},{entry._content},{entry._prompt}");
                }

                Console.WriteLine("Entries saved to file successfully.");
                Console.WriteLine($"File location: {fullFilePath}");
            }
            else
            {
                Console.WriteLine("No entries to save.");
            }
        }
    }
    
    public void LoadFromFile(string fileName)
    {
        
        string currentDirectory = Environment.CurrentDirectory;
        string fullFilePath = Path.Combine(currentDirectory,  "Journal", fileName);
        
        if (File.Exists(fullFilePath))
        {
            List<JournalEntry> loadedEntries = new List<JournalEntry>();
            string[] lines = File.ReadAllLines(fullFilePath);
            foreach (var line in lines)
            {
                string[] values = line.Split(',');
                if (values.Length == 3)
                {
                    string date = values[0];
                    string content = values[1];
                    string prompt = values[2];

                    JournalEntry loadedEntry = new JournalEntry(date, content, prompt);
                    loadedEntries.Add(loadedEntry);
                }
                else
                {
                    Console.WriteLine($"Invalid line in the file: {line}.");
                }
            }

            foreach (var loadedEntry in loadedEntries)
            {
                Console.WriteLine("Loaded entries from dates:");
                Console.WriteLine($"{loadedEntry._date}");

            }

            entries.AddRange(loadedEntries);
            Console.WriteLine("Entries loaded successfully.");
        
        }
        else
        {
            Console.WriteLine($"File not found: " + fileName);
        }
    }
}




class Menu
{
    public static void Display()
    {

        Console.WriteLine();
        Console.WriteLine("Journal Menu");
        Console.WriteLine();
        Console.WriteLine("1. New Entry");
        Console.WriteLine("2. Display Entries");
        Console.WriteLine("3. Save Journal");
        Console.WriteLine("4. Load Journal");
        Console.WriteLine("5. Quit");
        Console.WriteLine();
    }
    public static int GetInput()
    {
        int userChoice;
        while (true)
        {
            Console.Write("Enter your choice (1-5): ");
            string userInput = Console.ReadLine();
            userChoice = int.Parse(userInput);

            if (!(userChoice >= 1 && userChoice <= 5))
            {
                Console.WriteLine("Invalid Option.");
            }
            else
            {
                return userChoice;
            }
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        string fileName = "journal_entries.csv";
        Journal myJournal = new Journal();

        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following options:");

        bool quit = false;

        while (!quit)
        {
            Menu.Display();

            int userChoice = Menu.GetInput();
            switch (userChoice)
            {
                case 1:
                    myJournal.AddEntry();
                    break;
                case 2:
                    myJournal.DisplayEntries();
                    break;
                case 3:
                    myJournal.SaveToFile(myJournal.entries, fileName);
                    break;
                case 4:
                    myJournal.LoadFromFile(fileName);
                    break;
                case 5:
                    quit = true;
                    break;
            }
        }

    }
}
