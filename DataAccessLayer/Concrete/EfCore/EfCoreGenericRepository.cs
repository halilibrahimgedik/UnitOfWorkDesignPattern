using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class
    {

        protected readonly Context _context;
        public EfCoreGenericRepository(Context context)
        {
            _context = context;
        }

        public void Create(TEntity t)
        {
            _context.Set<TEntity>().Add(t);
           
        }

        public void Delete(TEntity t)
        {

            _context.Set<TEntity>().Remove(t);
            

        }

        public List<TEntity> GetAll()
        {

            return _context.Set<TEntity>().ToList();

        }

        public TEntity GetById(int id)
        {

            return _context.Set<TEntity>().Find(id);

        }

        public void Update(TEntity t)
        {

            _context.Entry(t).State = EntityState.Modified;
            _context.Set<TEntity>().Update(t);

        }
    }
}
