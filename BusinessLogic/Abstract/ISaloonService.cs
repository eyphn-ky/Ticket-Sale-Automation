using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstract
{
    public interface ISaloonService
    {
        List<Saloon> GetAll(Expression<Func<Saloon, bool>> filter = null);
        Saloon Get(Expression<Func<Saloon, bool>> filter);
        void Add(Saloon entity);
        void Update(Saloon entity);
        void Delete(Saloon entity);
    }
}
