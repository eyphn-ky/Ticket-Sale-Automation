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
   public  class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void Add(Customer entity)
        {
            _customerDal.Add(entity);
        }

        public void Delete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            return _customerDal.Get(filter);
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            return _customerDal.GetAll();
        }

        public bool IsRegistered(Customer customer)
        {
            Customer customer1 = _customerDal.Get(
            p => p.Id == customer.Id
            && p.Name == customer.Name
            && p.LastName == customer.LastName
            && p.Password == customer.Password);
            if(customer1.Name==null)
            {
               return false;
            }
            else
            {
                return true;
            }
        }

        public void Update(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}
