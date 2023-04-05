using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10 IMDb movies array
            string[] topMovies = { "The Shawshank Redemption", "The Godfather", "The Godfather: Part II", "The Dark Knight", "12 Angry Men", "Schindler's List", "The Lord of the Rings: The Return of the King", "Pulp Fiction", "The Lord of the Rings: The Fellowship of the Ring", "Forrest Gump" };

            // Loop until the user enters "exit"
            while (true)
            {
                // Enter a movie
                Console.Write("Enter a movie to watch (or type 'exit' to quit): ");
                string movie = Console.ReadLine();

                if (movie.ToLower() == "exit")
                {
                    // Exit the program if the user enters "exit"
                    break;
                }
                else if (Array.IndexOf(topMovies, movie) == -1)


                            // For Loop
                            // Also should be else not else if
                            //bool foundMovie = false;
                            //for (int i = 0; i < topMovies.Length; i++)
                            //{
                               // if (topMovies[i].Equals(movie, StringComparison.OrdinalIgnoreCase))
                               // {
                                   // foundMovie = true;
                                   // break;
                              //  }
                           // }
                           // Then i will check with if statement if movie founded and else if it didn't founded will give results.

                            {
                    // Display a message if the movie is not in the list
                    Console.WriteLine("Sorry, we don't have that movie.");
                }
                else
                {
                    // Display a message if the movie is in the list
                    Console.WriteLine("Great choice! Enjoy watching " + movie + ".");
                }
            }
        }
    }
}