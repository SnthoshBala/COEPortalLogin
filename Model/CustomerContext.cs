using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace COE_Portal_API.Model
{
    public class CustomerContext:DbContext
    {
        private const string connection = "Server=KANINI-LTP-467\\SQLSERVER19AMIT;Database=coeportal;Trusted_Connection=True;";
        public CustomerContext()
        {

        }
        public CustomerContext(DbContextOptions<CustomerContext> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
