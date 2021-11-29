using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace COE_Portal_API.Model
{
    public class CustomerContext:DbContext
    {
        private const string connection = "Server=tcp:coeportal.database.windows.net,1433;Initial Catalog=Coeportal;Persist Security Info=False;User ID=coeportal;Password=Raguraman@007;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
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
