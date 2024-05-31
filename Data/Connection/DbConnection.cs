using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Connection
{
    public class DbConnection:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-S5D23V6\\SQLEXPRESS;initial catalog=RiskApiDb;integrated Security=true;TrustServerCertificate=true;");
            
        }
        public DbSet<Category> Category { get; set; }

        public DbSet<Product> Products { get; set; }


        


    }
}
