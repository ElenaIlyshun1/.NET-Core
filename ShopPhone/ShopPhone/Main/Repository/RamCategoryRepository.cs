using ShopPhone.Main.Interfaces;
using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.Repository
{
    public class RamCategoryRepository : IRamCategory
    {
        private readonly DBContent dbContent;
        public RamCategoryRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<RamCategory> AllRamsCategories => dbContent.RamCategories;
    }
}
