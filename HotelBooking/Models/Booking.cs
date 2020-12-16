using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public float Price { get; set; }
        public string PaymentType { get; set; }

        [Required]
        [Display(Name ="Days")]
        public int NumberOfDays { get; set; }

        [Required]
        [Display(Name = "Rooms")]
        public int NumberOfRooms { get; set; }
        public string CustomerId { get; set; }

        [NotMapped]
        public int Id { get; set; }
        public Hotel Hotel { get; set; }


    }
}
