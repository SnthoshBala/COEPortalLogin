using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COE_Portal_API.Model;

namespace COE_Portal_API.Service
{
    public interface ICustomerService<Customer>
    {
        public object LoginCustomer(string tempPhone, string tempPass);
        public List<Customer> GetAllCustomer();
    }
}
