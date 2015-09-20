namespace ER.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductPropertyCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductPropertyCategories",
                c => new
                    {
                        ProductPropertyCategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ProductPropertyCategoryId);
            
            AddColumn("dbo.ProductProperties", "ProductPropertyCategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.ProductProperties", "ProductPropertyCategoryId");
            AddForeignKey("dbo.ProductProperties", "ProductPropertyCategoryId", "dbo.ProductPropertyCategories", "ProductPropertyCategoryId", cascadeDelete: true);
            DropColumn("dbo.Products", "RawProperties");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "RawProperties", c => c.String());
            DropForeignKey("dbo.ProductProperties", "ProductPropertyCategoryId", "dbo.ProductPropertyCategories");
            DropIndex("dbo.ProductProperties", new[] { "ProductPropertyCategoryId" });
            DropColumn("dbo.ProductProperties", "ProductPropertyCategoryId");
            DropTable("dbo.ProductPropertyCategories");
        }
    }
}
