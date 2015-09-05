using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER.Data.DomainObjects
{
    public class Seller
    {
        public int Key { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public Dictionary<string,string> PropertyCollection { get; set; }
    }
}
