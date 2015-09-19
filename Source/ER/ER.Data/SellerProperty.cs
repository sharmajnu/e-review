using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER.Data
{
    public class SellerProperty
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
    }
}
