using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER.Data
{
    public class Image
    {
        public int ImageId { get; set; }
        public string Uri { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
