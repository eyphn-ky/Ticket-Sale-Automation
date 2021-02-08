using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDateDal : EfEntityRepositoryBase<Date, CinemaContext>, IDateDal
    {
        public List<SessionDetailDto> GetSessionDetails(Expression<Func<SessionDetailDto, bool>> filter)
        {
            using (CinemaContext context = new CinemaContext())
            {
                var result = from d in context.Dates
                             join s in context.Sessions
                             on d.SessionId equals s.Id
                             join m in context.Movies
                             on d.MovieId equals m.Id
                             select new SessionDetailDto
                             {
                                 Day = d.Day,
                                 MovieName = m.Name,
                                 SessionName = s.Time,
                                 SessionId = s.Id,
                                 MovieId=m.Id
                             };

                return result.Where(filter).ToList();

            }
        }
    }
}
