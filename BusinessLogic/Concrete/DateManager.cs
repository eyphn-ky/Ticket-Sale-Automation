using BusinessLogic.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Concrete
{
    public class DateManager : IDateService
    {
        private IDateDal _dateDal;
        public DateManager(IDateDal dateDal)
        {
            _dateDal = dateDal;
        }
        public void Add(Date entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Date entity)
        {
            throw new NotImplementedException();
        }

        public Date Get(Expression<Func<Date, bool>> filter)
        {
            throw new NotImplementedException();
        }
        public List<Date> GetDateByMovieId(int Id)
        {
            return _dateDal.GetAll(p=>p.MovieId==Id);
        }
         
        public List<Date> GetAll(Expression<Func<Date, bool>> filter)
        {
            return _dateDal.GetAll();
        }

        public void Update(Date entity)
        {
            throw new NotImplementedException();
        }
        
        public List<SessionDetailDto> GetSessionDetails(int Id,string Date)
        {
            return _dateDal.GetSessionDetails(p=>p.MovieId==Id && p.Day==Date);
        }

       
    }
}
