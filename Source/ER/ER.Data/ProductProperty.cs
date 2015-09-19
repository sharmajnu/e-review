using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER.Data
{
    public class ProductProperty
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ProductPropertyCategoryId { get; set; }
        public ProductPropertyCategory ProductPropertyCategory { get; set; }
    }
}
