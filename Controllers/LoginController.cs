using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using COE_Portal_API.Model;
using COE_Portal_API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace COE_Portal_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ICustomerService<Customer> cs;
        public LoginController(ICustomerService<Customer> _cs)
        {
            cs = _cs;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return Ok(cs.GetAllCustomer());
        }
        [HttpPost]
        public IActionResult Login(string tempPhone, string tempPass)
        {
            return Ok(cs.LoginCustomer( tempPhone,  tempPass));
        }
    }
}