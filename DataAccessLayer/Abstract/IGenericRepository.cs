﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericRepository<T> 
    {
        T GetById(int id);

        List<T> GetAll();

        void Create(T t);

        void Update(T t);

        void Delete(T t);
    }
}
