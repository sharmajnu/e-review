namespace ER.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropertyID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ProductProperties");
            DropPrimaryKey("dbo.SellerProperties");
            AlterColumn("dbo.ProductProperties", "Name", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.SellerProperties", "Name", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.ProductProperties", new[] { "ProductId", "Name" });
            AddPrimaryKey("dbo.SellerProperties", new[] { "SellerId", "Name" });
            DropColumn("dbo.ProductProperties", "ProductPropertyId");
            DropColumn("dbo.SellerProperties", "SellerPropertyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SellerProperties", "SellerPropertyId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.ProductProperties", "ProductPropertyId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.SellerProperties");
            DropPrimaryKey("dbo.ProductProperties");
            AlterColumn("dbo.SellerProperties", "Name", c => c.String());
            AlterColumn("dbo.ProductProperties", "Name", c => c.String());
            AddPrimaryKey("dbo.SellerProperties", "SellerPropertyId");
            AddPrimaryKey("dbo.ProductProperties", "ProductPropertyId");
        }
    }
}
