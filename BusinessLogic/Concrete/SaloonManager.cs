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
    public class SaloonManager : ISaloonService
    {
        public void Add(Saloon entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Saloon entity)
        {
            throw new NotImplementedException();
        }

        public Saloon Get(Expression<Func<Saloon, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Saloon> GetAll(Expression<Func<Saloon, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Saloon entity)
        {
            throw new NotImplementedException();
        }
    }
}
