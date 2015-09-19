using System.Collections.Generic;

namespace ER.Data
{
    public class Seller
    {
        public int SellerId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public List<SellerProperty> Properties { get; set; }
        public List<Product> Products { get; set; }
    }
}
