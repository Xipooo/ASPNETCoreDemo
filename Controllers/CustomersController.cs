using System;
using System.Collections.Generic;
using ASPNETCoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using ASPNETCoreDemo.Repositories;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace ASPNETCoreDemo.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private readonly ILogger<CustomersController> _logger;

        public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            _logger.LogTrace("Id requested: " + Id);
            try
            {
                List<Customer> customers = new CustomersRepository().GetAll();
                Customer customer = customers.FirstOrDefault(cust => cust.Id == Id);
                return Ok(customer);
            }
            catch (System.Exception ex)
            {
                _logger.LogCritical("*** Critical Error ***");
                _logger.LogCritical(ex.Message);
                return this.BadRequest();
            }
        }

        [HttpPost]
        public Customer Post([FromForm] int id, [FromForm] string firstName, [FromForm] string lastName)
        {
            Console.WriteLine($"Id: {id}, FirstName: {firstName}, LastName: {lastName}");
            Customer customer = new Customer()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName
            };
            return customer;
        }
    }
}