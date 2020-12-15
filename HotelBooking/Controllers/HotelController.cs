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

        // GET: HotelController/Details/
        public ActionResult Details(int id)
        {
            var hotelViewModel = new HotelViewModel();
            hotelViewModel.Hotel = hotelRepository.Get(id);
            return View(hotelViewModel);
        }

        // GET: HotelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HotelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HotelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HotelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HotelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HotelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
