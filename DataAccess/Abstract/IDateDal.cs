using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDateDal:IEntityRepository<Date>
    {
        List<SessionDetailDto> GetSessionDetails(Expression<Func<SessionDetailDto, bool>> filter);
    }
}
