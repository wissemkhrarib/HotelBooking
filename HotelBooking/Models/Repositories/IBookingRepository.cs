using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Models.Repositories
{
    public interface IBookingRepository:IRepository<Booking>
    {
        public IEnumerable<Booking> GetByCustomer(string id);
    }
}
