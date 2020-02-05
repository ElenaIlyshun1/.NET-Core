using Microsoft.AspNetCore.Mvc;
using ShopPhone.Main.Interfaces;
using ShopPhone.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Controllers
{
    public class RamController : Controller
    {
        private readonly IAllRam _allRam;
        private readonly IRamCategory _allRamCategories;

        public RamController(IAllRam iallRam, IRamCategory iRamCategory)
        {
            _allRam = iallRam;
            _allRamCategories = iRamCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Ram";
            RamListViewModel obj = new RamListViewModel();
            obj.allRams = _allRam.rams;
            obj.currentCategory = "Ram: ";

            return View(obj);
        }
    }
}
