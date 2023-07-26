using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemUOW.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class, new()
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetAll();
        T GetById(int id);
        void MultiUpdate(List<T> t);
    }
}
