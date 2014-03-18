using System.Data.Entity.Migrations;
using Data.Migrations.Seed;

namespace Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyContext context)
        {
            CustomerSeed.Seed(context);
        }
    }
}
