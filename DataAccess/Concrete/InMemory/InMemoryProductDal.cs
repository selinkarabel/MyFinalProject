using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal // data access code of Product will be written in this class; InMemory is the way of access the data
    {
        List<Product> _products; // global variables has naming convention as _... 
                                // we'll add our products to simulate the data

        public InMemoryProductDal() //constructor
        {
            _products = new List<Product> { // it creates products like it comes from Oracle, Sql Server, Postfres, Mongo DB
            new Product{ProductId=1, CategoryId=1, ProductName="Glass",UnitPrice=15, UnitsInStock=15},
            new Product{ProductId=2, CategoryId=1, ProductName="Camera",UnitPrice=500, UnitsInStock=3},
            new Product{ProductId=3, CategoryId=2, ProductName="Phone",UnitPrice=1500, UnitsInStock=2},
            new Product{ProductId=4, CategoryId=2, ProductName="Keyboard",UnitPrice=150, UnitsInStock=65},
            new Product{ProductId=5, CategoryId=2, ProductName="Mouse",UnitPrice=85, UnitsInStock=1},
            }; //heap has 5 addresses
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product) // new product comes with new referance number
        {
            //_products.Remove(product) does not work for different referance number;this method can not find which product should be deleted into the array because of new ref. number

            //Product productToDelete = null;
            //foreach (var p in _products) // if we dont have LINQ, we have to search item into array one bu one
            //{
            //    if(product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}
            //_products.Remove(productToDelete);

            //LINQ = LANGUAGE INTEGRATED QUERY
            //lINQ can filter the data of array 
                                                                //p is alias, here is like foreach
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId); // SingleOrDefault search one id
                                                //SingleOrDefault is a method of Linq
            _products.Remove(productToDelete); //it operates deletion operation

        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            //Find the product in the list which I sent productId
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;//product comes from UI which is selected on the screen
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList(); // where returns the datas inside the new list
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
