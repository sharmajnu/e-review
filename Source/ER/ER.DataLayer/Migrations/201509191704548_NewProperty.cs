namespace ER.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "RawProperties", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "RawProperties");
        }
    }
}
