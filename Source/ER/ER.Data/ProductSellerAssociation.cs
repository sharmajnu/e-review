using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER.Data
{
    public class ProductSellerAssociation
    {
        public int ProductSellerAssociationId{ get; set; }
        public int ProductId { get; set; }
        public int SellerId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Seller Seller { get; set; }
        public string ProductLink { get; set; }
        public string ReviewLink { get; set; }
    }
}
