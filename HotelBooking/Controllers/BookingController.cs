using HotelBooking.Models;
using HotelBooking.Models.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Controllers
{
    [Authorize]
    public class BookingController : Controller
    {
        private readonly IRepository<Booking> bookingRepository;
        private readonly IRepository<Hotel> hotelRepository;

        public BookingController(IRepository<Booking> bookingRepository, IRepository<Hotel> hotelRepository)
        {
            this.bookingRepository = bookingRepository;
            this.hotelRepository = hotelRepository;
        }
        public IActionResult Create(int HotelId)
        {
            var booking = new Booking();
            booking.Hotel = hotelRepository.Get(1);
            return View(booking);
        }

        [HttpPost]
        public IActionResult Create(Booking booking)
        {
            booking.Price = booking.NumberOfDays * booking.NumberOfRooms;
            bookingRepository.Add(booking);
            return RedirectToAction("Index","Hotel");
        }
    }
}
