using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COE_Portal_API.Model;

namespace COE_Portal_API.Repository
{
    public class CustomerRepository : ICustomerRepository<Customer>
    {
        private readonly CustomerContext cc = new CustomerContext();
        public List<Customer> GetAllCustomer()
        {
            return cc.Customers.ToList();
        }

        public object LoginCustomer(Customer c)
        {
            try
            {
                List<Customer> lc = cc.Customers.ToList();
                if (lc.Count != 0)
                {
                    if (lc.Any(u => (u.Email == c.Email || u.PhoneNumber == c.PhoneNumber) && u.Password == c.Password))
                    {
                        return lc.Where(u => (u.Email == c.Email || u.PhoneNumber == c.PhoneNumber) && u.Password == c.Password).First();
                    }
                    else
                    {
                        return "Invalid User";
                    }
                }
                else
                {
                    return "Database is Empty";
                }
            }
            catch(Exception e)
            {
                return e;
            }
        }
    }
}
