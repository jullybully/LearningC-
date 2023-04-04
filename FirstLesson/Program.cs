using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display questions.
            Console.WriteLine("Welcome to the Language Learning App!");
            Console.WriteLine("Which language would you like to learn?");
            Console.WriteLine("1. C#");
            Console.WriteLine("2. Java");
            Console.WriteLine("3. GoLang");
            Console.Write("Please enter the number of your choice: ");
            string languageChoice = Console.ReadLine();

            int choice = int.Parse(languageChoice);


            // Using keyboard switch.
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You have chosen to learn C#.");
                    // Code to display information about C# lessons and cost.
                    break;
                case 2:
                    Console.WriteLine("You have chosen to learn Java.");
                    // Code to display information about Java lessons and cost.
                    break;
                case 3:
                    Console.WriteLine("You have chosen to learn GoLang.");
                    // Code to display information about GoLang lessons and cost.
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            // integer for lessons and decimal for price.
            int numLessons = 459; 
            decimal cost = 49.69m; 

            Console.WriteLine($"There are {numLessons} lessons for {languageChoice}.");
            Console.WriteLine($"The cost for these lessons is {cost:C}.");

            Console.Write("Have you previously learned this language? (y/n) ");
            string answer = Console.ReadLine();

            
            bool previouslyLearned = answer.ToLower() == "y";

            if (previouslyLearned)
            {
                Console.WriteLine("Great, we will tailor the lessons to your level.");
            }
            else
            {
                Console.WriteLine("No worries, we will start from the beginning.");
            }

        }
    }
}
