using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[][] exercises = new string[7][];

            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                Console.WriteLine("Enter your exercise preferences for {0}:", daysOfWeek[i]);
                Console.WriteLine("How many exercises do you want to do?");
                int numExercises = int.Parse(Console.ReadLine());

                exercises[i] = new string[numExercises];

                for (int j = 0; j < numExercises; j++)
                {
                    Console.WriteLine("Enter exercise {0}:", j + 1);
                    exercises[i][j] = Console.ReadLine();
                }
            }
            Console.WriteLine("Here are your exercise preferences for the week:");
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                Console.WriteLine("{0}:", daysOfWeek[i]);
                for (int j = 0; j < exercises[i].Length; j++)
                {
                    Console.WriteLine("- {0}", exercises[i][j]);
                }
            }
        }
    }
}