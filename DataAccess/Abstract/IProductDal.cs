using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal // Product means product entity table, Dal means data access layer or Dao means data access object
                                   // this interface includes operations according to Product into in DB
    {
        List<Product> GetAll();

        // methods of interface are public as default
        void Add(Product product); 
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId); //Filter the products according to Category
    
    }
}
