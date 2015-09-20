using ER.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER.DataLayer
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<YoutubeLink> YoutubeLinks { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductSellerAssociation> ProductSellerAssociations { get; set; }
        public DbSet<SellerProperty> SellerProperties { get; set; }
        public DbSet<ProductProperty> ProductProperties { get; set; }
        public DbSet<ProductPropertyCategory> ProductPropertyCategories { get; set; }

        public DataContext()
            : base()
        {
        }

        public DataContext(string connectionString)
            : base(connectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SellerProperty>().HasKey(x => new { x.SellerId, x.Name });
            modelBuilder.Entity<ProductProperty>().HasKey(x => new { x.ProductId, x.Name });
            base.OnModelCreating(modelBuilder);
        }

        public static DataContext CreateNew()
        {
            return new DataContext("Name=ereview");
        }
    }
}
