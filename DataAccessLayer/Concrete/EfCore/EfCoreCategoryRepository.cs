using DataAccessLayer.Abstract;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(Context context) : base(context)
        {

        }

        private Context context { get { return context as Context; } }

        // ICategoryRepository'deki sadece Categorylere özel olan bir metot
        // Crud işlemleri GenericRepository'den geliyor
        public List<Category> GetPopulerCategories()
        {
            throw new NotImplementedException();
        }
    }
}
