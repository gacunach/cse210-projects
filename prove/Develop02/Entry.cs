using System;


public class Entry
{
    public string _date = DateTime.Now.ToString("yyyy-MM-dd");

    public string _prompt;
    public string _userEntry;
    

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"{_userEntry}");
        Console.WriteLine("");
    }
}