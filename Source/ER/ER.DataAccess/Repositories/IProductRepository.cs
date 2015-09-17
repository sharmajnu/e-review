using ER.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER.DataAccess
{
    public interface IProductRepository
    {
        int Add(Product product);
        void Remove(int key);
        void Update(Product product);
        List<Product> GetAllProducts();
        List<Product> GetProductByCategory(ProductCategory category);
        List<Product> Find(Product product);
    }
}
