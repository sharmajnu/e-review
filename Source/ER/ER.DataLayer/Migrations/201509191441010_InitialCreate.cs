namespace ER.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImageId = c.Int(nullable: false, identity: true),
                        Uri = c.String(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ImageId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProductCategoryId = c.Int(nullable: false),
                        Seller_SellerId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Sellers", t => t.Seller_SellerId)
                .Index(t => t.ProductCategoryId)
                .Index(t => t.Seller_SellerId);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        ProductCategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ProductCategoryId);
            
            CreateTable(
                "dbo.ProductProperties",
                c => new
                    {
                        ProductPropertyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductPropertyId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductSellerAssociations",
                c => new
                    {
                        ProductSellerAssociationId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        SellerId = c.Int(nullable: false),
                        ProductLink = c.String(),
                        ReviewLink = c.String(),
                    })
                .PrimaryKey(t => t.ProductSellerAssociationId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Sellers", t => t.SellerId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.SellerId);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        SellerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.SellerId);
            
            CreateTable(
                "dbo.SellerProperties",
                c => new
                    {
                        SellerPropertyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        SellerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SellerPropertyId)
                .ForeignKey("dbo.Sellers", t => t.SellerId, cascadeDelete: true)
                .Index(t => t.SellerId);
            
            CreateTable(
                "dbo.YoutubeLinks",
                c => new
                    {
                        YoutubeLinkId = c.Int(nullable: false, identity: true),
                        Link = c.String(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.YoutubeLinkId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.YoutubeLinks", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductSellerAssociations", "SellerId", "dbo.Sellers");
            DropForeignKey("dbo.SellerProperties", "SellerId", "dbo.Sellers");
            DropForeignKey("dbo.Products", "Seller_SellerId", "dbo.Sellers");
            DropForeignKey("dbo.ProductSellerAssociations", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductProperties", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Images", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "ProductCategoryId", "dbo.ProductCategories");
            DropIndex("dbo.YoutubeLinks", new[] { "ProductId" });
            DropIndex("dbo.SellerProperties", new[] { "SellerId" });
            DropIndex("dbo.ProductSellerAssociations", new[] { "SellerId" });
            DropIndex("dbo.ProductSellerAssociations", new[] { "ProductId" });
            DropIndex("dbo.ProductProperties", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "Seller_SellerId" });
            DropIndex("dbo.Products", new[] { "ProductCategoryId" });
            DropIndex("dbo.Images", new[] { "ProductId" });
            DropTable("dbo.YoutubeLinks");
            DropTable("dbo.SellerProperties");
            DropTable("dbo.Sellers");
            DropTable("dbo.ProductSellerAssociations");
            DropTable("dbo.ProductProperties");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Products");
            DropTable("dbo.Images");
        }
    }
}
