using BusinessLogic.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Concrete
{
    public class SeatManager : ISeatService
    {
        private ISeatDal _seatDal;
        public SeatManager(ISeatDal seatDal)
        {
            _seatDal = seatDal;
        }
        public void Add(Seat entity)
        {
            _seatDal.Add(entity);
        }

        public void Delete(Seat entity)
        {
            _seatDal.Add(entity);
        }

        public Seat Get(Expression<Func<Seat, bool>> filter)
        {
            return _seatDal.Get(filter);
        }

        public List<Seat> GetAll(Expression<Func<Seat, bool>> filter)
        {
            return _seatDal.GetAll();
        }
        public List<Seat> GetSeatBySaloonId(int Id)
        {
            return _seatDal.GetAll(p => p.SaloonId == Id);
        }

        public void Update(Seat entity)
        {
            _seatDal.Update(entity); 
        }
    }
}
