using Microsoft.AspNetCore.Mvc;
using ShopPhone.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Controllers
{
    public class MotherboardsController : Controller
    {

        private readonly IAllMotherboards _allMotherboards;
        private readonly IMotherboardsCategory _allMotherboardCategories;

        //public MotherboardsController(IAllMotherboards iallMotherboards, IMotherboardsCategory imotherboardCategory)
        //{
        //    _allMotherboards = iallMotherboards;
        //    _allMotherboardCategories = imotherboardCategory;
        //}

        //public ViewResult List()
        //{
        //    ViewBag.Title = "Motherboard";
        //    MotherboardListViewModel obj = new MotherboardListViewModel();
        //    obj.allMotherboards = _allMotherboards.motherboards;
        //    obj.currentCategory = "Motherboards : ";

        //    return View(obj);
        //}
    }
}
