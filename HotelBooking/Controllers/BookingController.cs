using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Controllers
{
    public class BookingController : Controller
    {
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }
    }
}
