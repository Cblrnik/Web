using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Data.Interfaces;
using WebSite.Data.Models;

namespace WebSite.Data.mocks
{
    public class MockCategory : ICellCategories
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {NameOfCategory = "Легковые автомобили", Description = "Вид транспорта, использующийся для перевозки пассажиров "},
                    new Category {NameOfCategory = "Грузовые автомобили", Description = "Вид транспорта, использующийся для перевозки грузов "}
                };
            }
        }
    }
}
