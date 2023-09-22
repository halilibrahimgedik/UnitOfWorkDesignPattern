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
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        private readonly Context _context;

        public EfCoreProductRepository(Context context) : base(context)
        {
            _context = context;
        }

        //private Context context
        //{
        //    get
        //    {
        //        return context as Context;
        //    }
        //}


        // Sadece Productlara Özel metotlar IProductRepositoryden gelecek
        // Crud işlemleri EfCoreGenericRepository'den geliyor
        public List<Product> GetPopulerProducts()
        {

            // örnek amcı yla böyle bir sorgu yazabilirsin
            return _context.Products.Where(x => x.ProductId > 0).ToList();

        }

        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {

            // örnek amcı yla böyle bir sorgu yazabilirsin
            return _context.Products.Where(x => x.ProductId > 0).ToList();

        }

        public List<Product> GetTop5Products()
        {

            // örnek amcı yla böyle bir sorgu yazabilirsin
            return _context.Products.Where(x => x.ProductId > 0).ToList();

        }
    }
}
