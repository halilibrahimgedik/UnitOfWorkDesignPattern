﻿using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EfCore
{
    public class EfCoreOrderRepository : EfCoreGenericRepository<Order>,IOrderRepository
    {
        private readonly Context context;
        public EfCoreOrderRepository(Context context) : base(context)
        {
            this.context = context;
        }
    }
}
