using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository productRepository {  get;}

        ICategoryRepository categoryRepository { get;}

        IOrderRepository orderRepository { get;}

        void Save();

    }
}
