using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COE_Portal_API.Model;
using COE_Portal_API.Repository;

namespace COE_Portal_API.Service
{
    public class CustomerService : ICustomerService<Customer>
    {
        private readonly ICustomerRepository<Customer> cr;
        public CustomerService(ICustomerRepository<Customer> _cr)
        {
            cr = _cr;
        }
        public List<Customer> GetAllCustomer()
        {
            return cr.GetAllCustomer();
        }

        public object LoginCustomer(string tempPhone, string tempPass)
        {
            return cr.LoginCustomer( tempPhone, tempPass);
        }
    }
}
