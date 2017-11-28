using System.Collections.Generic;
using System.Linq;
using ASPNETCoreDemo.Models;
using ASPNETCoreDemo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreDemo.Controllers
{
    public class CustomerPageController : Controller
    {
        [HttpGet]
        public IActionResult Index(int Id){
            List<Customer> customers = new CustomersRepository().GetAll();
            Customer customer = customers.FirstOrDefault(cust => cust.Id == Id);
            return View(customer);
        }

        public IActionResult OtherIndex(){
            return View();
        }
    }
}