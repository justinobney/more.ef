using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Domain.Customers;

namespace Data
{
    public class MyContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations
                .Add(new CustomerEntityTypeConfiguration());
        }
    }
}
