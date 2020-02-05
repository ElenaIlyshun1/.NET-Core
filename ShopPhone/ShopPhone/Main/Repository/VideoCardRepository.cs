using Microsoft.EntityFrameworkCore;
using ShopPhone.Main.Interfaces;
using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.Repository
{
    public class VideoCardRepository : IAllVideoCards
    {
        private readonly DBContent dbContent;
        public VideoCardRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<VideoCard> videoCards => dbContent.VideoCards.Include(c => c.VideoCardCategory);
    }
}
