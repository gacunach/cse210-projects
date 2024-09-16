using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int guess;
        do 
        {
            Console.Write("What's your guess? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);
                    if (number > guess)
            {
                Console.WriteLine("Higher!");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower!");
            }
            else 
            {
                Console.WriteLine("Congratulations, you guessed the number!");
            }
        } while (number != guess);



    }
}