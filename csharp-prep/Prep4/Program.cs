using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int input;
        List<int> numbers = new List<int>();
        do 
        {
            Console.Write("Enter Number: ");
            string userInput = Console.ReadLine();
            input = int.Parse(userInput);
            numbers.Add(input);

            

        } while (input != 0);
        
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;    
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum)/ (numbers.Count - 1);

        Console.WriteLine($"The average is: {average}");

        int max = 0;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
        
    }
}