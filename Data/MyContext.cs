using System.Data.Entity;
using Domain.Customers;

namespace Data
{
    public class MyContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
