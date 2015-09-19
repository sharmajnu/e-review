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
        public int ProductCategoryId { get; set; }
        public ProductCategory Category { get; set; }
        
        public List<ProductProperty> Properties { get; set; }
        
        public List<Image> Images { get; set; }
        public List<YoutubeLink> YoutubeLinks { get; set; }
        public List<ProductSellerAssociation> SoldBy { get; set; }
    }
}
