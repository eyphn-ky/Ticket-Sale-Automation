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
    public class ReservationManager : IReservationService
    {
        private IReservationDal _reservationDal;
        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }
        public void Add(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public Reservation Get(Expression<Func<Reservation, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetAll(Expression<Func<Reservation, bool>> filter = null)
        {
            return _reservationDal.GetAll();
        }

        public List<Reservation> GetReservationsEmptyOrSold(int movieId, int sessionId, int saloonId, string Day)
        {
            return _reservationDal.GetAll(p=>p.Date==Day && p.MovieId==movieId && p.SaloonId==saloonId && p.SessionId==sessionId);
        }

        public void Update(Reservation entity)
        {
            throw new NotImplementedException();
        }
    }
}
