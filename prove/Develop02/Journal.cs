using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {
    }

    public void AddEntry(Entry _newEntry)
    {
        _entries.Add(_newEntry);
    } 
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        
        using (StreamWriter writer = new StreamWriter(file))
        {    
            writer.WriteLine("Date,Prompt,Entry");

            foreach (var entry in _entries)
            {
                
                string date = EscapeForCsv(entry._date);
                string prompt = EscapeForCsv(entry._prompt);
                string userEntry = EscapeForCsv(entry._userEntry);

                
                writer.WriteLine($"Date: {date},Prompt: {prompt},{userEntry}");
            }
        }
    }
    private string EscapeForCsv(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";
        
        if (input.Contains(",") || input.Contains("\""))
        {
        
            input = input.Replace("\"", "\"\"");
            return $"\"{input}\""; 
        }
        return input;
    }
    
        
    public void LoadFromFile(string file)
    {
         _entries.Clear(); 

        using (StreamReader reader = new StreamReader(file))
        {
            reader.ReadLine(); 

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = ParseCsvLine(line);

                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string userEntry = parts[2];

                    Console.WriteLine("");
                    Console.WriteLine(date);
                    Console.WriteLine(prompt);
                    Console.WriteLine(userEntry);
                    Console.WriteLine("");

                    
                    Entry entry = new Entry()
                    {
                        _date = date 
                    };

                    _entries.Add(entry);
                }
            }
        }
    }

    private string[] ParseCsvLine(string line)
    {
        List<string> result = new List<string>();
        bool inQuotes = false;
        string currentField = "";

        foreach (char c in line)
        {
            if (c == '"' && inQuotes)
            {
                if (currentField.Length > 0 && currentField[currentField.Length - 1] == '"')
                {
                    currentField = currentField.Remove(currentField.Length - 1) + '"';
                }
                else
                {
                    inQuotes = !inQuotes;
                }
            }
            else if (c == ',' && !inQuotes)
            {
                result.Add(currentField);
                currentField = "";
            }
            else
            {
                currentField += c;
            }
        }

        result.Add(currentField);
        return result.ToArray();
    }

}