using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Number Generator");

            // Prompt the user for the minimum and maximum values
            Console.Write("Enter the minimum value: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Enter the maximum value: ");
            int max = int.Parse(Console.ReadLine());

            // Prompt the user for additional options
            Console.Write("Allow negative values? (y/n): ");
            bool allowNegative = Console.ReadLine().ToLower() == "y";

            Console.Write("Allow decimal values? (y/n): ");
            bool allowDecimal = Console.ReadLine().ToLower() == "y";

            // Create a random number generator
            Random rand = new Random();

            // Generate a random number within the specified range
            double randomNum = 0;

            if (allowDecimal)
            {
                randomNum = (rand.NextDouble() * (max - min)) + min;
            }
            else
            {
                randomNum = rand.Next(min, max + 1);
            }

            if (!allowNegative && randomNum < 0)
            {
                randomNum = 0;
            }

            // Display the random number
            Console.WriteLine($"Your random number is: {randomNum}");
            Console.ReadLine();
        }
    }
}
