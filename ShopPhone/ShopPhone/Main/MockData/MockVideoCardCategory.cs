using ShopPhone.Main.Interfaces;
using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.MockData
{
    public class MockVideoCardCategory : IVideoCardCategory
    {
        public IEnumerable<VideoCardCategory> AllVideoCardsCategories
        {
            get
            {
                return new List<VideoCardCategory>
                {
                    new VideoCardCategory {categoryName = "Flagman", categoryDescription = "Video Card with low path"},
                    new VideoCardCategory {categoryName = "Budget", categoryDescription = "Video Card with hight path"}
                };
            }
        }
    }
}
