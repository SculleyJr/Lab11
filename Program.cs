using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesApp;

namespace MoviesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> categories = new List<string>
            {

                "SciFi",
                "Horror",
                "Animated",
                "Drama",
                "Close Program"
            };
            
            
            List<Movie> listOfMovies = new List<Movie>()
        {
            new Movie( "The Ring", "Horror"),
            new Movie("Winney The Poo", "Animated"),
            new Movie("The Ringer", "Drama"),
            new Movie("Star Wars", "SciFi"),
            new Movie("Pricess Bride", "Drama"),
            new Movie("Jumanji", "Drama"),
            new Movie("A Quiet Place", "Horror"),
            new Movie("A Thin Line", "Drama"),
            new Movie("Precious", "Drama"),
            new Movie("Pokemon The Movie", "Animated"),
        };

            
            bool run = true;
            while(run == true)
            {
                AskForCategory(categories);
                string cat = Console.ReadLine();
                switch (cat)
                {
                    case "1":
                        Console.WriteLine();
                        foreach (Movie movie in listOfMovies)
                        {
                            GetScifi(movie);
                        }


                        break;
                    case "2":
                        foreach (Movie movie in listOfMovies)
                        {
                            GetHorror(movie);
                        }

                        break;
                    case "3":
                        foreach (Movie movie in listOfMovies)
                        {
                            GetAnimated(movie);

                        }

                        break;
                    case "4":
                        foreach (Movie movie in listOfMovies)
                        {
                            GetDrama(movie);
                        }

                        break;
                    case "5":
                        run = false;
                        break;


                    default:
                        Console.WriteLine("not valid entry");
                        break;
                }
            }




        }

        private static void AskForCategory(List<string> categories)
        {
            Console.WriteLine("Select a category");
            Console.WriteLine();
            int n = 0;
            foreach (string category in categories)
            {
                n++;
                Console.WriteLine($"{n}:{category}");
            }
        }

        private static void GetDrama(Movie movie)
        {
            if ("Drama" == movie.GetCategory())
            {

                Console.WriteLine(movie.GetTitle());
            }
        }

        private static void GetAnimated(Movie movie)
        {
            if ("Animated" == movie.GetCategory())
            {

                Console.WriteLine(movie.GetTitle());
            }
        }

        private static void GetHorror(Movie movie)
        {
            if ("Horror" == movie.GetCategory())
            {
                Console.WriteLine(movie.GetTitle());
            }
        }

        private static void GetScifi(Movie movie)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if ("SciFi" == movie.GetCategory())

            {
                Console.WriteLine(movie.GetTitle());
            }
            Console.ResetColor();
        }
    }
}
