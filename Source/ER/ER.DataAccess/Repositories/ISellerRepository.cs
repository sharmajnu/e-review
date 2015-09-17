using ER.Data;
using System.Collections.Generic;

namespace ER.DataAccess
{
    interface ISellerRepository
    {
        int Add(Seller seller);
        void Remove(Seller seller);
        void Update(Seller seller);
        List<Seller> GetSellers();
    }
}
