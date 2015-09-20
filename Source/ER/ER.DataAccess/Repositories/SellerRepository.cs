using ER.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER.DataAccess
{
    public class SellerRepository : ISellerRepository
    {
        public SellerRepository()
        {
        }

        public int Add(Seller seller)
        {
            using (var context = DataContext.CreateNew())
            {
                context.Database.Log = Console.WriteLine;
                context.Sellers.Add(seller);
                context.SaveChanges();
                return seller.SellerId;
            }
        }

        public void Remove(Seller seller)
        {
            using (var context = DataContext.CreateNew())
            {
                context.Sellers.Remove(seller);
                context.SaveChangesAsync();
            }
        }

        public void Update(Seller seller)
        {
            using (var context = DataContext.CreateNew())
            {
                context.Database.Log = Console.WriteLine;

                foreach (var item in seller.Properties)
                {
                    if(context.SellerProperties.FirstOrDefault(x=>x.SellerId == item.SellerId) !=null)
                    {
                        context.SellerProperties.Attach(item);
                        context.Entry(item).State = EntityState.Modified;
                        
                    }
                    else
                    {
                        context.SellerProperties.Add(item);
                        context.Entry(item).State = EntityState.Added;
                    }
                }
                context.Sellers.Attach(seller);
                context.Entry(seller).State = EntityState.Modified;
                context.SaveChangesAsync();
            }
        }

        public List<Seller> GetSellers()
        {
            using (var context = DataContext.CreateNew())
            {
                return context.Sellers.ToList();
            }
        }
    }
}
