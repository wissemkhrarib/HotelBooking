
using HotelBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.ViewModels
{
    public class HotelViewModel {
        public IEnumerable<Hotel> Hotels { get; set; }
        public Hotel Hotel { get; set; }

    }



}
