using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);

        List<Product> GetAll();

        void Create(Product product);

        void Update(Product product);

        void Delete(Product product);


        // Product'a özel metotlar
        List<Product> GetPopulerProducts();

        List<Product> GetTop5Products();

        List<Product> GetProductsByCategory(string name, int page, int pageSize);
    }
}
