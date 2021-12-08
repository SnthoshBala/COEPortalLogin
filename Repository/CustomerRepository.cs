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

        public object LoginCustomer(string tempPhone, string tempPass)
        {
            try
            {
                List<Customer> lc = cc.Customers.ToList();
                if (lc.Count != 0)
                {
                    if (lc.Any(u => ( u.PhoneNumber == tempPhone) && u.Password == tempPass))
                    {
                        return lc.Where(u => ( u.PhoneNumber == tempPhone) && u.Password == tempPass).First();
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
