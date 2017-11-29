using System.Collections.Generic;
using ASPNETCoreDemo.Models;

namespace ASPNETCoreDemo.Repositories
{
    public class CustomersRepository
    {
        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer { Id = 1, FirstName = "Steve", LastName = "Bishop" });
            customers.Add(new Customer { Id = 2, FirstName = "Enes", LastName = "Hanson" });
            customers.Add(new Customer { Id = 3, FirstName = "Robert", LastName = "Fike" });
            throw new System.Exception("I Had an Error!");
            return customers;
        }
    }
}