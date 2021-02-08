using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstract
{
     public interface ISeatService
    {
        List<Seat> GetAll(Expression<Func<Seat, bool>> filter = null);
        Seat Get(Expression<Func<Seat, bool>> filter);
        List<Seat> GetSeatBySaloonId(int Id);
        void Add(Seat entity);
        void Update(Seat entity);
        void Delete(Seat entity);
    }
}
