using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstract
{
    public interface ISessionService
    {
        List<Session> GetAll(Expression<Func<Session, bool>> filter = null);
        Session Get(Expression<Func<Session, bool>> filter);
        void Add(Session entity);
        void Update(Session entity);
        void Delete(Session entity);
    }
}
