using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(DateTime.Now, 30, 4.8),
            new Cycling(DateTime.Now, 45, 20.0),
            new Swimming(DateTime.Now, 25, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    
    }
}