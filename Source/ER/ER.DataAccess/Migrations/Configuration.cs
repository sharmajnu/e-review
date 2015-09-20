using System.Data.Entity.Migrations;
using ER.Data;

namespace ER.DataAccess.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ER.DataAccess.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ER.DataAccess.DataContext context)
        {
            context.ProductCategories.AddOrUpdate(new ProductCategory { ProductCategoryId = 1, Name = "Mobile" });
        }
    }
}
