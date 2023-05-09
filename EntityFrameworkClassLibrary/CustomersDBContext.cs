using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkClassLibrary
{
   public class CustomersDBContext:DbContext
    {
        public  DbSet<Customers> Customers { get; set; }

        public CustomersDBContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=.;Initial Catalog=CustomerOrders;Integrated Security=True;TrustServerCertificate=True;");
  
        }
    }
}
