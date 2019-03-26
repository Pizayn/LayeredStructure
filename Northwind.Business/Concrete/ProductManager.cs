using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using Northwind.Business.Abstract;
using System.Data.Entity.Infrastructure;
using Northwind.Business.ValidationRules.FluentValidation;
using FluentValidation;
using Northwind.Business.Utilities;

namespace Northwind.Business.Concrete
{
    public class ProductManager:IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productdal)
        {
            _productDal = productdal;
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            //alttaki ifade hatadır.Bu hatayı almamız durumunda mesajı iletilmesine ve programın çökmemesine yardımcı olur
            //bu ifadelerin burada yazılması beklenmez.
            catch (DbUpdateException e )
            {

                throw new Exception("Silme gerçekleşemedi");
            }
            
        }

        public List<Product> GetAll()
        {
            //business code yazılır 
            return _productDal.GetAll();
        }

        public List<Product> GetProducsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductByName(string productName)
        {

            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Updated(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }
    }
}
