using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstract
{
    public interface IDateService
    {
        List<Date> GetAll(Expression<Func<Date, bool>> filter = null);
        List<Date> GetDateByMovieId(int Id);
        List<SessionDetailDto> GetSessionDetails(int Id , string Date);
        Date Get(Expression<Func<Date, bool>> filter);
        void Add(Date entity);
        void Update(Date entity);
        void Delete(Date entity);
    }
}
