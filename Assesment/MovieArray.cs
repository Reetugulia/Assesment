using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class MovieArray
    {
        private Movie[] movies;
        private int size;
        private const int capacity = 100;  

        public MovieArray()
        {
            movies = new Movie[capacity];
            size = 0;
        }

        // Create (Insert) operation
        public void AddMovie(int id, string name, double p, string prod)
        {
            if (size < capacity)
            {
                movies[size] = new Movie { MovieId = id, Moviename = name, Ticketprice = p, producer = prod };
                size++;
                Console.WriteLine($"Movie '{name}' added successfully");
            }
            else
            {
                Console.WriteLine("Movie collection is full");
            }
        }

        
        public void DisplayMovies()
        {
            Console.WriteLine("List of Movies:");
            
             for(int i = 0;i<size;i++) 
               {
                  Console.WriteLine($"{movies[i].MovieId}, {movies[i].Moviename}, {movies[i].Ticketprice},{movies[i].producer}");
                }
                    //Console.WriteLine($"Id: {movie.MovieId}, Movie name: {movie.Moviename}, Ticketprice: {movie.Ticketprice}, producer: {movie.producer}");
                
            
        }

        
        public void UpdateMovie(int id, string name, double p, string prod)
        {
            foreach (var movie in movies)
            {
                if (movie?.MovieId == id)
                {
                    movie.Moviename = name;
                    movie.Ticketprice = p;
                    movie.producer = prod;
                    Console.WriteLine($"Movie with Id {id} updated successfully");
                    return;
                }
            }
            Console.WriteLine($"Movie with Id {id} not found");
        }

      
        public void DeleteMovie(int id)
        {
            for (int i = 0; i < size; i++)
            {
                if (movies[i]?.MovieId == id)
                {
                    movies[i] = null;
                    Console.WriteLine($"Movie with Id {id} deleted successfully");
                    return;
                }
            }
            Console.WriteLine($"Movie with Id {id} not found");
        }
        public void SearchMoviebyId(int id)
        {
            foreach (var movie in movies)
            {
                if (movie?.MovieId == id)
                {
                    
                    Console.WriteLine($"Movie with Id {id} is present");
                    Console.WriteLine($"{ movie.MovieId}  { movie.Moviename}  {movie.Ticketprice}  {movie.producer}");
                    return;
                }
            }
            Console.WriteLine($"please enter valid id");
        }
        public void SearchMoviebyname(string name)
        {
            foreach (var movie in movies)
            {
                if (movie?.Moviename == name)
                {

                    Console.WriteLine($"Movie with {name} is present");
                    Console.WriteLine($"{movie.MovieId}  {movie.Moviename}  {movie.Ticketprice}  {movie.producer}");
                    return;
                }
            }
            Console.WriteLine($"please enter valid name");
        }
    }
}

