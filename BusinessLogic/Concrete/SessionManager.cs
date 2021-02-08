using BusinessLogic.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Concrete
{
    public class SessionManager : ISessionService
    {
        private ISessionDal _sessionDal;
        public SessionManager(ISessionDal sessionDal)
        {
            _sessionDal = sessionDal;
        }
        public void Add(Session entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Session entity)
        {
            throw new NotImplementedException();
        }

        public Session Get(Expression<Func<Session, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Session> GetAll(Expression<Func<Session, bool>> filter = null)
        {
            return _sessionDal.GetAll();
        }

        public void Update(Session entity)
        {
            throw new NotImplementedException();
        }
    }
}
