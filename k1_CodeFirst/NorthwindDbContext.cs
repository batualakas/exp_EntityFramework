using k1_CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_CodeFirst
{
    class NorthwindDbContext : DbContext
    {
        public NorthwindDbContext()
        {
            this.Database.Connection.ConnectionString =
                "Server=.;Database=Northwind;User Id=sa;Password=123;";
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
