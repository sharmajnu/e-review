using ER.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER.DataAccess
{
    public class SellerRepository : BaseRepository, ISellerRepository
    {
        public SellerRepository(DataContext context) : base(context)
        {
        }

        public int Add(Seller seller)
        {
            _Context.Seller.Add(seller);
            return seller.SellerId;
        }

        public void Remove(Seller seller)
        {
            throw new NotImplementedException();
        }

        public void Update(Seller seller)
        {
            throw new NotImplementedException();
        }

        public List<Seller> GetSellers()
        {
            throw new NotImplementedException();
        }
    }
}
