using Microsoft.AspNetCore.Mvc;
using ShopPhone.Main.Interfaces;
using ShopPhone.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Controllers
{
    public class VideoCardController : Controller
    {
        private readonly IAllVideoCards _allVideoCard;
        private readonly IVideoCardCategory _allVideoCardCategories;

        public VideoCardController(IAllVideoCards iallVideoCard, IVideoCardCategory iVideoCardCategory)
        {
            _allVideoCard = iallVideoCard;
            _allVideoCardCategories = iVideoCardCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Video Card";
            VideoCardListViewModel obj = new VideoCardListViewModel();
            obj.allVideoCards = _allVideoCard.videoCards;
            obj.currentCategory = "Video Card: ";

            return View(obj);
        }
    }
}
