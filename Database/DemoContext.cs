using ASPNETCoreDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreDemo.Database
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set;}
        public DbSet<Company> Companies { get; set;}

    }
}