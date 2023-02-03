using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace TheMovies
{
    class MovieRepo
    {
        List<Movie> movies;

        List<Booking> bookings;
        Movie movie;
        Booking booking;

        public MovieRepo()
        {
            movies = new List<Movie>();
            bookings = new List<Booking>();



        }


        public void GetMovie()
        {
            using (StreamReader sr = new StreamReader("TheMovies.csv"))
            {
                List<string> strings = new List<string>();


                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    strings.Add(line);

                }

                foreach (string line in strings)
                {
                    string[] split = line.Split(";");
                    movie = new Movie(split[3], int.Parse(split[5]), split[6], DateOnly.Parse(split[7]), split[4], split[1]);
                    booking = new Booking(split[8], int.Parse(split[9]), DateTime.Parse(split[2]));

                    movies.Add(movie);
                    bookings.Add(booking);

                }
            }

        }

    }
}
