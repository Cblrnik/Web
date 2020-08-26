using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Data.Models
{
    public class Cell
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortdesc { get; set; }
        public string fulldesc { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public bool avaliable { get; set; }
        public int categoryid { get; set; }
        public virtual Category Category { get; set; }
    }
}
