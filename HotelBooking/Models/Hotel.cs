using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int StarRating { get; set; }
        public string Description { get; set; }

        public string PhotoUrl { get; set; }
        public List<Image> Images { get; set; }


    }
}
