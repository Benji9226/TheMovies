using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies
{
    class Booking
    {
        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public DateTime PlayingTime { get; set; }

        public Booking (string email, int phoneNumber, DateTime playingTime)
        {
            Email = email;
            PhoneNumber = phoneNumber;
            PlayingTime = playingTime;
        }


    }
}
