using ER.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER.DataAccess
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Seller { get; set; }

        public DataContext(string connectionString)
            : base(connectionString)
        {
        }

        public static DataContext GetContext()
        {
            return new DataContext("Name=ereview");
        }
    }
}
