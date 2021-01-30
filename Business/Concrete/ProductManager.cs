using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal) //constructor injection
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            // business codes
            //has privilage? 

            return _productDal.GetAll();
        }
    }
}
