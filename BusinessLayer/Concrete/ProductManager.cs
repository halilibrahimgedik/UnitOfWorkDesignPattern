using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EfCore;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        //burada EfCoreProductRepository'e bağımlılık yok || 2.injection işlemi
        private readonly IUnitOfWork _unitOfWork;

        public ProductManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public void Create(Product product)
        {
            // iş kuralları uygulanacak
            _unitOfWork.productRepository.Create(product);
            _unitOfWork.Save();
        }

        public void Delete(Product product)
        {
            // silmek için iş kuralları uygulanacak
            _unitOfWork.productRepository.Delete(product);
            _unitOfWork.Save();
        }

        public List<Product> GetAll()
        {
            return _unitOfWork.productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _unitOfWork.productRepository.GetById(id);
        }

        public void Update(Product product)
        {
            _unitOfWork.productRepository.Update(product);
            _unitOfWork.Save();
        }


        // Product'a özel metotlar
        public List<Product> GetPopulerProducts()
        {
            return _unitOfWork.productRepository.GetPopulerProducts();
        }

        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {
            return _unitOfWork.productRepository.GetProductsByCategory(name, page, pageSize);
        }

        public List<Product> GetTop5Products()
        {
            return _unitOfWork.productRepository.GetTop5Products();
        }
    }
}
