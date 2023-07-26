using CasgemUOW.DataAccessLayer.Concrete;
using CasgemUOW.DataAccessLayer.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemUOW.DataAccessLayer.UnitOfWork.Concrete
{
    public class UnitOfWorkDal : IUnitOfWorkDal
    {
        private readonly Context _context;

        public UnitOfWorkDal(Context context)
        {
            _context = context;
        }

        public void Commit() //Sultan Abdülhamit Hanın mührüdür. Veriyi DB'de kalıcı hale getirir.
        {
            _context.SaveChanges(); //DB'de verileri kalıcı hale getirir.
        }
    }
}