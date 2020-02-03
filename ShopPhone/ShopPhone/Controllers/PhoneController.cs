using Microsoft.AspNetCore.Mvc;
using ShopPhone.Main.Interfaces;
using ShopPhone.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ShopPhone.Controllers
{
    public class PhoneController : Controller
    {
        private readonly IAllPhones _allPhones;
        private readonly IPhoneCategory _allCategories;

        public PhoneController(IAllPhones iAllPhones, IPhoneCategory iPhoneCategory)
        {
            _allPhones = iAllPhones;
            _allCategories = iPhoneCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Phones";
            PhoneListViewModel obj = new PhoneListViewModel();
            obj.allPhones = _allPhones.phones;
            obj.carrentCategory = "Best category";

            return View(obj);
        }
    }
}
