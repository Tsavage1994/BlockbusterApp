using System;
using System.Collections.Generic;

namespace Blockbuster_Lab
{
    static public class Blockbuster
   {
        public static List<Movie> Movie()
        {
            List<Movie> Movies = new List<Movie>();

            DVD TheSpongeBobMovie = new DVD();
            TheSpongeBobMovie.Title = "The SpongeBob Squarepants Movie";
            TheSpongeBobMovie.RunTimeInMinutes = 97;
            TheSpongeBobMovie.Category = (Movie.Genre)1;
            TheSpongeBobMovie.Scenes = new List<string>
            {
                { "He IS a MANager" },
                { "Save the town, Get the Crown and Mr. Krabs!" },
                { "We made it to Shell City" }
            };
            DVD Scream4 = new DVD();
            Scream4.Title = "Scream 4";
            Scream4.RunTimeInMinutes = 113;
            Scream4.Category = (Movie.Genre)2;
            Scream4.Scenes = new List<string>
            {
                {"Omg, a scary phone call!" },
                {"Maybe if I stay with my friend I will be safe." },
                {"He killed everyone but me, YIPPIE!" }
            };
            DVD ToyStoryAndysRevenge = new DVD();
            ToyStoryAndysRevenge.Title = "Toy Story: Andy's Revenge";
            ToyStoryAndysRevenge.RunTimeInMinutes = 165;
            ToyStoryAndysRevenge.Category = (Movie.Genre)0;
            ToyStoryAndysRevenge.Scenes = new List<string>
            {
                {"Now that I've gone to the therapist, I can face my fears." },
                {"Woody and Buzz..... we meet again." },
                {"How did the toys defeat me again? At least I got one of them! SO LONG BUZZ!" }
            };
            VHS FriedGreenTomatos = new VHS();
            FriedGreenTomatos.Title = "Fried Green Tomatoes";
            FriedGreenTomatos.RunTimeInMinutes = 120;
            FriedGreenTomatos.Category = (Movie.Genre)3;
            FriedGreenTomatos.Scenes = new List<string>
            {
                {"My Brother got killed by a train and I will never be the same after that" },
                {"Ruth is in my life now so things are better." },
                {"I fell in love with my best friend, then she died." }
            };
            VHS TheHeat = new VHS();
            TheHeat.Title = "The Heat";
            TheHeat.RunTimeInMinutes = 93;
            TheHeat.Category = (Movie.Genre)1;
            TheHeat.Scenes = new List<string>
            {
                {"Going to Boston to bust a big case" },
                {"Uh Oh! Not getting along with my partner." },
                {"We did it! We saved the day!" }
            }; 
            VHS Grease = new VHS();
            Grease.Title = "Grease";
            Grease.RunTimeInMinutes = 103;
            Grease.Category = (Movie.Genre)4;
            Grease.Scenes = new List<string>
            {
                {"Going to Boston to bust a big case" },
                {"Uh Oh! Not getting along with my partner." },
                {"We did it! We saved the day!" }
            };
            Movies.Add(TheSpongeBobMovie);
            Movies.Add(Scream4);
            Movies.Add(ToyStoryAndysRevenge);
            Movies.Add(FriedGreenTomatos);
            Movies.Add(TheHeat);
            Movies.Add(Grease);

            return Movies;
        }
        static public void PrintMovie(List<Movie> movies)
        {
            var index = 0;
            foreach (var movie in movies)
            {
                Console.WriteLine($"{index}: {movie.Title}");
                index++;
            }
        }
        static public Movie CheckOut()
        {
            List<Movie> movie = Movie();
            Movie userMovieSelection;
            do
            {
                Console.WriteLine("Which movie from our super dope selection would you like?");
                PrintMovie(movie);
                bool isInt = int.TryParse(Console.ReadLine(), out int movieNum);
                if(isInt && movieNum >= 0 && movieNum < movie.Count)
                {
                    movie[movieNum].PrintInfo();
                    userMovieSelection = movie[movieNum];
                    Console.WriteLine("Enjoy your movie!");
                    return userMovieSelection;
                }
                else 
                {
                    Console.WriteLine("Have a great night!");
                }
            } while (true);
            
        }
       
    }

}
