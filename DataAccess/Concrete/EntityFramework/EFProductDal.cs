using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return new List<Product> { 
                new Product { ProductId = 6, CategoryId = 1, ProductName = "Kazak", UnitPrice = 60, UnitsInStock = 12 },
                new Product { ProductId = 7, CategoryId = 2, ProductName = "Eşofman Altı", UnitPrice = 90, UnitsInStock = 15 }
            };
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
