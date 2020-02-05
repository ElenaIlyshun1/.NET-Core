using Microsoft.AspNetCore.Mvc;
using ShopPhone.Main.Interfaces;
using ShopPhone.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Controllers
{
    public class ProcesorController : Controller
    {
        private readonly IAllProcesors _allProcesors;
        private readonly IProcesorCategory _procesorCategory;

        public ProcesorController(IAllProcesors iallProcesors, IProcesorCategory iprocesorCategory)
        {
            _allProcesors = iallProcesors;
            _procesorCategory = iprocesorCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Procesor";
            ProcesorListViewModel obj = new ProcesorListViewModel();
            obj.allProcesors = _allProcesors.procesors;
            obj.currentCategory = "Procesor : ";

            return View(obj);
        }
    }
}
