using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //context: joins db tables and class of projects
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //this method indicates which db this program uses
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true"); //we'll use Sql server, we have to define how it connects sql server
        }
        public DbSet<Product> Products { get; set; } //indicates which table matches which class

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
