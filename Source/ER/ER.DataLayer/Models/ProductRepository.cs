using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using ER.Data;
using ER.DataLayer;
using ER.DataLayer.RepositoryInterfaces;

namespace ER.DataLayer.Models
{ 
    public class ProductRepository : IProductRepository
    {
        DataContext context = new DataContext();

        public IEnumerable<Product> All
        {
            get { return context.Products; }
        }

        public IEnumerable<Product> AllIncluding(params Expression<Func<Product, object>>[] includeProperties)
        {
            IQueryable<Product> query = context.Products;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Product Find(int id)
        {
            return context.Products.Find(id);
        }

        public void InsertOrUpdate(Product product)
        {
            if (product.ProductId == default(int)) {
                // New entity
                context.Products.Add(product);
            } else {
                // Existing entity
                context.Entry(product).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var product = context.Products.Find(id);
            context.Products.Remove(product);
        }
    }
}