using System.Data.Entity.ModelConfiguration;
using Domain.Customers;

namespace Data.Migrations.EF_Config
{
    public class AddressEntityTypeConfiguration : EntityTypeConfiguration<Address>
    {
        public AddressEntityTypeConfiguration()
        {
            Property(a => a.State)
                .HasMaxLength(2);
        }
    }
}