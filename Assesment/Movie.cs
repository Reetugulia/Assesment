using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Moviename { get; set; }
        public double Ticketprice { get; set; }
        public string producer  { get; set; }

       /* public static void Display(Movie movie)
        {
            Console.WriteLine($"{movie.MovieId}, {movie.Moviename},{movie.Ticketprice},  {movie.producer}");
        }*/


        static void Main(string[] args)
        {

            MovieArray mv = new MovieArray();

          
          /*  mv.AddMovie(1, "Alchimist",300, "ester hicks");
            mv.AddMovie(2, "The Dark Knight",400, "Christopher Nolan");
            mv.AddMovie(3, "Pulp Fiction",500, "Niclo tesla");*/
            int option;
            char ch;
            int num;
            int id;
            string name;
            double p;
            string prod;


            do
            {
                Console.WriteLine("enter you option");
                Console.WriteLine("1.add new movie");
                Console.WriteLine("2.update movie");
                Console.WriteLine("3.display all movies");
                Console.WriteLine("4.Delete movie by id");
                Console.WriteLine("5.search movie by id");
                Console.WriteLine("6.search  movie by name");

                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:Console.WriteLine("add movie");
                        Console.WriteLine("how many movies you want to add");
                        num=Convert.ToInt32(Console.ReadLine());
                        for(int i=0;i<num;i++)
                        {

                         Console.WriteLine("enter movie id");
                         id=Convert.ToInt32(Console.ReadLine());
                         Console.WriteLine("enter movie name");
                         name=Console.ReadLine();
                         Console.WriteLine("enter ticket price");
                         p=Convert.ToDouble(Console.ReadLine());
                         Console.WriteLine("enter producer name");
                         prod=Console.ReadLine();
                        mv.AddMovie(id, name, p,prod);
                        }
                        break;
                    case 2:Console.WriteLine("---update movies-----");
                        Console.WriteLine("enter movie id");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter movie name");
                        name = Console.ReadLine();
                        Console.WriteLine("enter ticket price");
                        p = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter producer name");
                        prod = Console.ReadLine();
                        mv.UpdateMovie(id, name, p, prod);

                        break;
                    case 3:Console.WriteLine("---Display all movies-----");
                        mv.DisplayMovies();
                        break;
                    case 4:Console.WriteLine("---delete movie by id");
                        Console.WriteLine("enter the id of movie");
                        id=Convert.ToInt32(Console.ReadLine()) ;
                        mv.DeleteMovie(id);
                        break;
                    case 5:Console.WriteLine("search movie by id------");
                        Console.WriteLine("enter the id of movie");
                        id = Convert.ToInt32(Console.ReadLine());
                        mv.SearchMoviebyId(id);
                        break;
                     case 6:Console.WriteLine("search movie by name-----");
                         Console.WriteLine("enter the name  of movie");
                         name =Console.ReadLine();
                          mv.SearchMoviebyname(name);
                        break;
                    default:Console.WriteLine("enter valid option");
                           break;


                }
                Console.WriteLine("do u want to continue?");
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'y' || ch == 'Y');
            
          //  mv.DisplayMovies();

           
          //  mv.UpdateMovie(2, "The Dark", 500,"ester hicks");

            
          //  mv.DisplayMovies();

           // mv.DeleteMovie(1);

           
          


            
        }
    }
            
}
