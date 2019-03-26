using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetProducsByCategory(int categoryId);
        List<Product> GetProductByName(string productName);
        void Add(Product product);
        void Updated(Product product);
        void Delete(Product product);
    }
}
