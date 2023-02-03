using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies
{
    class Movie
    {
        public string Name { get; set; }

        public int Length { get; set; }

        public string Producer { get; set; }

        public DateOnly ReleaseDate { get; set; }

        public string Genre { get; set; }  

        public string City { get; set; }   

        public Movie(string name, int length, string producer, DateOnly releaseDate, string genre, string city )
        {
            Name = name;
            Length = length;
            Producer = producer;
            ReleaseDate = releaseDate;
            Genre = genre;
            City = city;
        }
    }
}
