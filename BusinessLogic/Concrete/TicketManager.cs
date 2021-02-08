using BusinessLogic.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Concrete
{
     public class TicketManager : ITicketService
    {
        public void Add(Ticket entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Ticket entity)
        {
            throw new NotImplementedException();
        }

        public Ticket Get(Expression<Func<Ticket, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Ticket> GetAll(Expression<Func<Ticket, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Ticket entity)
        {
            throw new NotImplementedException();
        }
    }
}
