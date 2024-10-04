// Two scriptures are added the user can choose one to memorize and the program runs for that scripture
using System;
using System.Runtime.InteropServices.Marshalling;


class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Alma", 37, 37);
        string scriptureText1 = "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.";

        Scripture scripture1 = new Scripture(reference1, scriptureText1);

        Reference reference2 = new Reference("Moroni", 10, 4, 5);
        string scriptureText2 = "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things..";

        Scripture scripture2 = new Scripture(reference2, scriptureText2);

        Console.WriteLine("Choose the number of the scripture you want to learn:");
        Console.WriteLine("1. Alma 37:37");
        Console.WriteLine("2.Moroni 10:4-5");

        string scriptureChosen = Console.ReadLine();
        int choiceNumber = int.Parse(scriptureChosen);

        if (choiceNumber == 1)
        {
            while (true)
            {   
                Console.Clear();
                Console.WriteLine(scripture1.GetDisplayText());

                if (scripture1.IsCompletelyHidden())
                {
                    Console.WriteLine("All words are hidden! Memorization complete.");
                    break;
                }

                Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                {
                    break;
                }

                scripture1.HideRandomWords(5); 
            }
        }
        else
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture2.GetDisplayText());

                if (scripture2.IsCompletelyHidden())
                {
                    Console.WriteLine("All words are hidden! Memorization complete.");
                    break;
                }

                Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                {
                    break;
                }

                scripture2.HideRandomWords(5); 
            }
    
        }
    }
        

       

    }
