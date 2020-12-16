using HotelBooking.Models;
using HotelBooking.Models.Repositories;
using HotelBooking.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Controllers
{
    public class HotelController : Controller
    {
        private readonly IRepository<Hotel> hotelRepository;

        public HotelController(IRepository<Hotel> hotelRepository)
        {
            this.hotelRepository = hotelRepository;
        }
        // GET: HotelController
        public ActionResult Index()
        {
            var hotelViewModel = new HotelViewModel();
            hotelViewModel.Hotels = hotelRepository.GetAll();
            return View(hotelViewModel);
        }

        [Authorize(Roles ="Admin")]
        public ActionResult IndexForAdmin()
        {
            var hotelViewModel = new HotelViewModel();
            hotelViewModel.Hotels = hotelRepository.GetAll();
            return View(hotelViewModel);
        }

        // GET: HotelController/Details/
        public ActionResult Details(int id)
        {
            var hotelViewModel = new HotelViewModel();
            hotelViewModel.Hotel = hotelRepository.Get(id);
            return View(hotelViewModel);
        }


        [Authorize(Roles = "Admin")]
        // GET: HotelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HotelController/Create
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hotel hotel)
        {
            hotelRepository.Add(hotel);
            return RedirectToAction("IndexForAdmin");
        }

        // GET: HotelController/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            var hotel = hotelRepository.Get(id);
            return View(hotel);
        }

        // POST: HotelController/Edit/5
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Hotel hotel)
        {
            hotelRepository.Update(hotel);
            return RedirectToAction("IndexForAdmin");
        }

        // GET: HotelController/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id,Hotel h=null)
        {
            var hotel = hotelRepository.Get(id);
            return View(hotel);
        }

        // POST: HotelController/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            hotelRepository.Delete(id);
            return RedirectToAction("IndexForAdmin");
        }
    }
}
