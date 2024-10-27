using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nPlayer Score: {_score}");
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been added yet.");
            return;
        }

        Console.WriteLine("\nGoals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
        Console.WriteLine("Goal added successfully.");
    }

    public void RecordEvent(int goalNumber)
    {
        if (goalNumber < 0 || goalNumber >= _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal selectedGoal = _goals[goalNumber];
        selectedGoal.RecordEvent();
        if (!selectedGoal.IsComplete())
        {
            _score += selectedGoal._points;
            Console.WriteLine($"Points earned: {selectedGoal._points}. Total score: {_score}");
        }
        else
        {
            Console.WriteLine("Goal is already completed.");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        _goals.Clear();
        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            _score = int.Parse(reader.ReadLine());
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Add parsing logic for each goal type as needed
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}

