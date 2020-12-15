using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public Room Room { get; set; }
        public int Price { get; set; }
        public int CustomerId { get; set; }


    }
}
