using ER.Data.DomainObjects;
using System.Collections.Generic;

namespace ER.Data
{
    interface ISellerRepository
    {
        int Add(Seller seller);
        void Remove(Seller seller);
        void Update(Seller seller);
        List<Seller> GetSellers();
    }
}
