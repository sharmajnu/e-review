namespace ER.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Uri : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductSellerAssociations", "ProductLink", c => c.String());
            AddColumn("dbo.ProductSellerAssociations", "ReviewLink", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductSellerAssociations", "ReviewLink");
            DropColumn("dbo.ProductSellerAssociations", "ProductLink");
        }
    }
}
