﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Models.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly AppDbContext appDbContext;

        public BookingRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void Add(Booking entity)
        {
            appDbContext.Bookings.Add(entity);
            appDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Booking Get(int id)
        {
           return appDbContext.Bookings.FirstOrDefault(b => b.BookingId == id);
        }

        public IEnumerable<Booking> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Booking entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Booking> GetByCustomer(string customerId)
        {
            return appDbContext.Bookings.Include(b=>b.Hotel).Where(b => b.CustomerId == customerId);
        }
    }
}
