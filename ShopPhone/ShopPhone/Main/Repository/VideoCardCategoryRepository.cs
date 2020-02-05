using ShopPhone.Main.Interfaces;
using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.Repository
{
    public class VideoCardCategoryRepository : IVideoCardCategory
    {
        private readonly DBContent dbContent;
        public VideoCardCategoryRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<VideoCardCategory> AllVideoCardsCategories => dbContent.VideoCardCategories;
    }
}
