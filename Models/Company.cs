using System.Collections.Generic;

namespace ASPNETCoreDemo.Models
{
    public class Company
    {
        public int Id { get; set; } 
        public string CompanyName { get; set; }
        public virtual List<Customer> Customers {get; set;}
    }
}