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
        private readonly IBookingRepository bookingRepository;
        private readonly IRepository<Hotel> hotelRepository;
        private readonly UserManager<IdentityUser> userManager;

        public BookingController(IBookingRepository bookingRepository, IRepository<Hotel> hotelRepository,UserManager<IdentityUser> userManager)
        {
            this.bookingRepository = bookingRepository;
            this.hotelRepository = hotelRepository;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var userId= userManager.GetUserId(HttpContext.User);
            var bookings = bookingRepository.GetByCustomer(userId);
            return View(bookings);
        }
        public IActionResult Create(int hotelId)
        {
            var booking = new Booking();
            booking.Hotel = hotelRepository.Get(hotelId);
            return View(booking);
        }

        [HttpPost]
        public IActionResult Create(Booking booking)
        {
            booking.CustomerId= userManager.GetUserId(HttpContext.User);
            booking.Hotel= hotelRepository.Get(booking.Id);
            booking.Price = booking.NumberOfDays * booking.NumberOfRooms * booking.Hotel.Price;
            bookingRepository.Add(booking);
            return RedirectToAction("Index","Hotel");
        }



    }
}
