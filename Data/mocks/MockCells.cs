using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Data.Interfaces;
using WebSite.Data.Models;

namespace WebSite.Data.mocks
{
    public class MockCells : ICells
    {
        private readonly ICellCategories cellCategories = new MockCategory();
        public IEnumerable<Cell> GetCells
        {
            get
            {   return new List<Cell> 
            {
                new Cell{name = "Citroen", 
                    shortdesc = "", 
                    fulldesc = "MyCar", 
                    avaliable = true, 
                    img = "", 
                    price = 6700, 
                    Category = cellCategories.AllCategories.First()}
            };
            }
        }

        public Cell SearchCell(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
