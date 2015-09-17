using ER.Data;
using System;
using System.Collections.Generic;

namespace ER.DataAccess
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(DataContext dt) : base(dt)
        {
        }

        public int Add(Product product)
        {
            _Context.Products.Add(product);
            return product.ProductId;
        }

        public void Remove(int key)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByCategory(ProductCategory category)
        {
            throw new NotImplementedException();
        }

        public List<Product> Find(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
