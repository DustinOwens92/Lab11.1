using System;
using System.Collections.Generic;

namespace Lab11._1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Movie> ListOfMovies = new List<Movie>()
            {
                new Scifi("2001: A Space Odyssey"),
                new Scifi("E.T. The Extra-terrestrial"),
                new Scifi("Star Wars"),
                new Scifi("A Clockwork Orange"),
                

                new Drama("Annabella"),
                new Drama("Black Panther"),
               

                new Animated("Big Hero 6"),
                new Animated("AristoCats"),
                

                new Horror("See No Evil"),
                new Horror("Paranormal Activity"),
               

            };

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 100 movies in this list.");


            string userCategory;
            do
            {
                Console.Write("\nWhat category would you be interested in? (animated, drama, horror, or scifi) ");
                userCategory = Console.ReadLine().ToLower();




                if (userCategory.Equals("animated", StringComparison.OrdinalIgnoreCase) ||
                    userCategory.Equals("drama", StringComparison.OrdinalIgnoreCase) ||
                    userCategory.Equals("horror", StringComparison.OrdinalIgnoreCase) ||
                    userCategory.Equals("scifi", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine();
                    foreach (var movie in ListOfMovies)
                    {
                        if (movie.Category.Contains(userCategory))
                        {
                            Console.WriteLine(movie);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nCategory does not exist in the list");
                }


            } while (UserContinue());

            Console.WriteLine();
            Console.WriteLine("\nBye!");
        }
        static bool UserContinue()
        {
            char userInput;
            do
            {
                Console.Write("\nContinue? (y/n) ");
                userInput = Console.ReadKey().KeyChar;
                userInput = char.ToLower(userInput);
                if (userInput == 'n')
                {
                    return false;
                }
                Console.WriteLine();

            } while (userInput != 'y');
            return true;
        }

    }
}
