using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Data.Interfaces;

namespace WebSite.Controllers
{
    public class CellsController : Controller
    {
        private readonly ICells AllCells;
        private readonly ICellCategories AllCategories;

        public CellsController(ICells cells,ICellCategories cellCategories)
        {
            AllCells = cells;
            AllCategories = cellCategories;
        }   
        public ViewResult List() 
        {
            ViewBag.Category = "Some body";
            var cells = AllCells.GetCells;
            return View(cells); 
        }

    }
}
