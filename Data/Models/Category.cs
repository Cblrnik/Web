using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string NameOfCategory { get; set; }
        public string Description { get; set; }
        public List<Cell> Cells { get; set; }
    }
}
