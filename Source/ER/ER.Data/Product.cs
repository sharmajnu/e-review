using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER.Data
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public ProductCategory Category { get; set; }
        public Dictionary<string,string> Properties { get; set; }
        public List<Uri> Images { get; set; }
        public List<Uri> YoutubeLinks { get; set; }
        List<ProductSellerAssociation> SoldBy { get; set; }
    }
}
