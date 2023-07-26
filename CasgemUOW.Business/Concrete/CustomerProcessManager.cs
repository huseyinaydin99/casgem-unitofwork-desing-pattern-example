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
    public class CustomerProcessManager : ICustomerProcessService
    {
        private readonly ICustomerProcessDal _customerProcessDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public CustomerProcessManager(ICustomerProcessDal customerProcessDal, IUnitOfWorkDal unitOfWorkDal)
        {
            _customerProcessDal = customerProcessDal;
            _unitOfWorkDal = unitOfWorkDal;
        }

        public void Delete(CustomerProcess t)
        {
            _customerProcessDal.Delete(t);
            _unitOfWorkDal.Commit();
        }

        public List<CustomerProcess> GetAll()
        {
            return _customerProcessDal.GetAll();
        }

        public CustomerProcess GetById(int id)
        {
            return _customerProcessDal.GetById(id);
        }

        public void Insert(CustomerProcess t)
        {
            _customerProcessDal.Insert(t);
            _unitOfWorkDal.Commit();
        }

        public void MultiUpdate(List<CustomerProcess> t)
        {
            _customerProcessDal.MultiUpdate(t);
            _unitOfWorkDal.Commit();
        }

        public void Update(CustomerProcess t)
        {
            _customerProcessDal.Update(t);
            _unitOfWorkDal.Commit();
        }
    }
}
