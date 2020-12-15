using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Models.Repositories
{
    public class BookingRepository : IRepository<Booking>
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

        public void Delete(Booking entity)
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

        public IEnumerable<Booking> GetByCustomer(int customerId)
        {
            return appDbContext.Bookings.Where(b => b.CustomerId == customerId);
        }
    }
}
