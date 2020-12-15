using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Models.Repositories
{
    public class HotelRepository : IRepository<Hotel>
    {
        private readonly AppDbContext appDbContext;

        public HotelRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void Add(Hotel entity)
        {
            appDbContext.Hotels.Add(entity);
            appDbContext.SaveChanges();
        }

        public void Delete(Hotel hotel)
        {
            appDbContext.Hotels.Remove(hotel);
            appDbContext.SaveChanges();
        }

        public Hotel Get(int id)
        {
            return appDbContext.Hotels.Include(h => h.Images).FirstOrDefault(h => h.HotelId == id);
        }

        public IEnumerable<Hotel> GetAll()
        {
            return appDbContext.Hotels.ToList();
        }

        public void Update(Hotel entity)
        {
            Hotel hotel = Get(entity.HotelId);
            hotel.Name = entity.Name;
            hotel.City = entity.City;
            hotel.StarRating = entity.StarRating;
        }
    }
}
