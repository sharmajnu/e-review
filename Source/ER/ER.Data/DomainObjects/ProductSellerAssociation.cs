using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER.Data.DomainObjects
{
    public class ProductSellerAssociation
    {
        public Product Product { get; set; }
        public Seller Seller { get; set; }
        public Uri ProductLink { get; set; }
        public Uri ReviewLink { get; set; }
    }
}
