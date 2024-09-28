using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompts = new PromptGenerator();

        Journal journal = new Journal();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = prompts.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your entry: ");
                    string entryText = Console.ReadLine();
                    Entry newEntry = new Entry();
                    newEntry._prompt = prompt;
                    newEntry._userEntry = entryText;
                    journal.AddEntry(newEntry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter file name to save to: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "4":
                    Console.Write("Enter file name to load from: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    
}