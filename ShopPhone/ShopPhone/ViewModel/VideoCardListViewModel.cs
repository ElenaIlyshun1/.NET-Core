using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.ViewModel
{
    public class VideoCardListViewModel
    {
        public IEnumerable<VideoCard> allVideoCards { set; get; }
        public string currentCategory { set; get; }
    }
}
