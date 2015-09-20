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
    public class SellerRepository : ISellerRepository
    {
        public IEnumerable<Seller> All
        {
            get 
            {
                using (var context = DataContext.CreateNew())
                {
                    return context.Sellers.Include("Properties").ToList();
                }
            }
        }

        public IEnumerable<Seller> AllIncluding(params Expression<Func<Seller, object>>[] includeProperties)
        {
            using (var context = DataContext.CreateNew())
            {
                IQueryable<Seller> query = context.Sellers;
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
                return query.ToList();
            }
        }

        public Seller Find(int id)
        {
            using (var context = DataContext.CreateNew())
            {
                return context.Sellers.Find(id);
            }
        }

        public void InsertOrUpdate(Seller seller)
        {
            using (var context = DataContext.CreateNew())
            {

                if (seller.SellerId == default(int))
                {
                    context.Sellers.Add(seller);
                }
                else
                {
                    UpdateSeller(seller, context);
                }
                context.SaveChanges();
            }
        }

        private void UpdateSeller(Seller seller, DataContext context)
        {
            PrepareObjectGraph(seller, context);
            MarkSellerAsModified(seller, context);
            DeleteExistingProperties(seller, context);
            MarkAllPropertiesAsNew(seller, context);
        }

        private void MarkAllPropertiesAsNew(Seller seller, DataContext context)
        {
            seller.Properties.ForEach(x => context.Entry(x).State = EntityState.Added);
        }

        private void DeleteExistingProperties(Seller seller, DataContext context)
        {
            context.Database.ExecuteSqlCommand("DELETE from SellerProperties where SellerId = " + seller.SellerId);
        }

        private void MarkSellerAsModified(Seller seller, DataContext context)
        {
            context.Entry(seller).State = EntityState.Modified;
        }

        private void PrepareObjectGraph(Seller seller, DataContext context)
        {
            context.Sellers.Add(seller);
        }

        public void Delete(int id)
        {
            using (var context = DataContext.CreateNew())
            {
                var seller = context.Sellers.Find(id);
                context.Sellers.Remove(seller);
                context.SaveChanges();
            }
        }
    }
}