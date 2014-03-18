using System.Data.Entity.ModelConfiguration;
using Domain.Customers;

namespace Data.Migrations.EF_Config
{
    public class CustomerEntityTypeConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerEntityTypeConfiguration()
        {
            Property(c => c.FirstName)
                .IsRequired();
        }
    }
}