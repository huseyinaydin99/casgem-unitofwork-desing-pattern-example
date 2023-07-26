using CasgemUOW.BusinessLayer.Abstract;
using CasgemUOW.DataAccessLayer.Abstract;
using CasgemUOW.DataAccessLayer.UnitOfWork.Abstract;
using CasgemUOW.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemUOW.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public CustomerManager(ICustomerDal customerDal, IUnitOfWorkDal unitOfWorkDal)
        {
            _customerDal = customerDal;
            _unitOfWorkDal = unitOfWorkDal;
        }

        public void Delete(Customer t)
        {
            _customerDal.Delete(t);
            _unitOfWorkDal.Commit();
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer GetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void Insert(Customer t)
        {
            _customerDal.Insert(t);
            _unitOfWorkDal.Commit();
        }

        public void MultiUpdate(List<Customer> t)
        {
            _customerDal.MultiUpdate(t);
            _unitOfWorkDal.Commit();
        }

        public void Update(Customer t)
        {
            _customerDal.Update(t);
            _unitOfWorkDal.Commit();
        }
    }
}