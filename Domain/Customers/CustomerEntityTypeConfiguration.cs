using System.Data.Entity.ModelConfiguration;

namespace Domain.Customers
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