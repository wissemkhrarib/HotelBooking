
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Models.Repositories
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity entity);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        void Delete(TEntity entity);
        void Update(TEntity entity);

    }
}
