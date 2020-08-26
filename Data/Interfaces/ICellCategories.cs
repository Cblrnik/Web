using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Data.Models;

namespace WebSite.Data.Interfaces
{
    public interface ICellCategories
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
