﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COE_Portal_API.Model;

namespace COE_Portal_API.Repository
{
    public interface ICustomerRepository<Customer>
    {
        public object LoginCustomer(Customer c);
        public List<Customer> GetAllCustomer();
    }
}
