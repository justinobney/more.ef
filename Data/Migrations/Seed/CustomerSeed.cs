using System.Data.Entity.Migrations;
using Domain.Customers;

namespace Data.Migrations.Seed
{
    public class CustomerSeed
    {
        public static void Seed(MyContext context)
        {
            context.Customers.AddOrUpdate(customer => customer.FirstName,
                new Customer
                {
                    FirstName = "Justin",
                    LastName = "Obney",
                    Address = new Address
                    {
                        Street = "123 Street",
                        City = "Baton Rouge",
                        State = "LA"
                    }
                });
        }
    }
}