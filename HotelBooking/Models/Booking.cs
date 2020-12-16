using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int Price { get; set; }
        public string PaymentType { get; set; }

        [Required]
        [Display(Name ="Days")]
        public int NumberOfDays { get; set; }

        [Required]
        [Display(Name = "Rooms")]
        public int NumberOfRooms { get; set; }
        public int CustomerId { get; set; }
        public Hotel Hotel { get; set; }


    }
}
