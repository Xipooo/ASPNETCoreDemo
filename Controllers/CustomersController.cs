using System;
using ASPNETCoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreDemo.Controllers
{
    [Route("api/Customers")]
    public class CustomersController : Controller
    {
        [HttpGet]
        public Customer Get()
        {
            Customer customer = new Customer();
            return customer;
        }

        [HttpPost]
        public Customer Post([FromForm] int id, [FromForm] string firstName, [FromForm] string lastName){
            Console.WriteLine($"Id: {id}, FirstName: {firstName}, LastName: {lastName}");
            Customer customer = new Customer() {
                Id = id,
                FirstName = firstName,
                LastName = lastName
            };
            return customer;
        }
    }
}