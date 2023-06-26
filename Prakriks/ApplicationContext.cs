using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prakriks.Models;
using Prakriks.Products;
using Prakriks.User;

namespace Prakriks
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Staff> Staffs { get; set; } = null!;
        public DbSet<User1> Users { get; set; } = null!;
        public DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public DbSet<SaleProduct> SalesProducts { get; set; } = null!;
        public DbSet<BasketProduct> BasketProducts { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Brovushka.db");
        }
    }
}
