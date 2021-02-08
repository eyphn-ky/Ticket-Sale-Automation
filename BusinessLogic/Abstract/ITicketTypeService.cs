using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstract
{
    public interface ITicketTypeService
    {
        List<TicketType> GetAll(Expression<Func<TicketType, bool>> filter = null);
        TicketType Get(Expression<Func<TicketType, bool>> filter);
        void Add(TicketType entity);
        void Update(TicketType entity);
        void Delete(TicketType entity);
    }
}
