namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerConfig : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Customers", newName: "Customer");
            RenameTable(name: "dbo.Addresses", newName: "Address");
            AlterColumn("dbo.Customer", "FirstName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customer", "FirstName", c => c.String());
            RenameTable(name: "dbo.Address", newName: "Addresses");
            RenameTable(name: "dbo.Customer", newName: "Customers");
        }
    }
}
