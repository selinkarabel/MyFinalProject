using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID => O --- Open Closed Principle //means if you add a new property into your program you can not change your existing codes.. 
    class Program
    {
        static void Main(string[] args)
        {
            //DTO: Data Transformation Object
            ProductTest();
            //IoC
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if(result.Success)
            {
                foreach (var product in productManager.GetProductDetails().Data) //.GetByUnitPrice(40,100)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
