using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        List<Product> GetPopulerProducts();

        List<Product> GetTop5Products();

        List<Product> GetProductsByCategory(string name, int page, int pageSize);
    }
}
