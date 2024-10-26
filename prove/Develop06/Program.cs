using System;

class Program
{
    private static GoalManager _goalManager = new GoalManager();
    static void Main(string[] args)
    {
        
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Create Goal");
            Console.WriteLine("4. Record Goal Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    _goalManager.DisplayPlayerInfo();
                    break;
                case "2":
                    _goalManager.ListGoals();
                    break;
                case "3":
                    CreateGoal();
                    break;
                case "4":
                    RecordGoalEvent();
                    break;
                case "5":
                    _goalManager.SaveGoals();
                    break;
                case "6":
                    _goalManager.LoadGoals();
                    break;
                case "7":
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void CreateGoal()
    {
        Console.Write("Enter goal type (1 = Simple, 2 = Eternal, 3 = Checklist): ");
        string goalType = Console.ReadLine();
        
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                _goalManager.CreateGoal(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goalManager.CreateGoal(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target number of completions: ");
                int target = int.Parse(Console.ReadLine());
                
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                
                _goalManager.CreateGoal(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    private static void RecordGoalEvent()
    {
        _goalManager.ListGoals();
        Console.Write("Enter the goal number to record: ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;
        _goalManager.RecordEvent(goalNumber);
    }
}