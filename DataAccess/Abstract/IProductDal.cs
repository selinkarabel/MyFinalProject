using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product> // 
        // Product means product entity table, Dal means data access layer or Dao means data access object
                                   // this interface includes operations according to Product into in DB
    {
        //will be written operation only for product like get details product or join products and their category
        List<ProductDetailDto> GetProductDetails();
    }
}

//code refactoring