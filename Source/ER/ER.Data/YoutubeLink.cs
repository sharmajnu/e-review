using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER.Data
{
    public class YoutubeLink
    {
        public int YoutubeLinkId { get; set; }
        public string Link { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
