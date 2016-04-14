namespace eCommerce.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Address1", c => c.String());
            AddColumn("dbo.Customers", "Address2", c => c.String());
            DropColumn("dbo.Customers", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Address", c => c.String());
            DropColumn("dbo.Customers", "Address2");
            DropColumn("dbo.Customers", "Address1");
        }
    }
}
