﻿using CasgemUOW.DataAccessLayer.Abstract;
using CasgemUOW.DataAccessLayer.Concrete;
using CasgemUOW.DataAccessLayer.Repositories;
using CasgemUOW.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemUOW.DataAccessLayer.EntityFramework
{
    public class EfCustomerProcessDal : GenericRepository<CustomerProcess> ,ICustomerProcessDal
    {
        public EfCustomerProcessDal(Context context) : base(context)
        {

        }
    }
}