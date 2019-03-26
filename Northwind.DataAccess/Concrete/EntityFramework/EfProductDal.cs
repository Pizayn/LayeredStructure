using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    //başına ef koyduk çünkü artık entity framework işlemlerini yapıyor
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
       
       
    }
}
