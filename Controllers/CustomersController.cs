using System;
using System.Collections.Generic;
using ASPNETCoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using ASPNETCoreDemo.Repositories;
using System.Linq;

namespace ASPNETCoreDemo.Controllers
{
    [Route("api/Customers")]
    public class CustomersController : Controller
    {
        [HttpGet("{Id}")]
        public Customer Get(int Id)
        {
            List<Customer> customers = new CustomersRepository().GetAll();
            Customer customer = customers.FirstOrDefault(cust => cust.Id == Id);
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