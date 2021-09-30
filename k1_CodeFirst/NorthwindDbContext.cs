using k1_CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_CodeFirst
{
    public class NorthwindDbContext : DbContext
    {
        public NorthwindDbContext()
        {
            this.Database.Connection.ConnectionString =
                "Server=.;Database=Northwind;User Id=sa;Password=123;";
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Detail> Order_Details { get; set; }
    }


}
