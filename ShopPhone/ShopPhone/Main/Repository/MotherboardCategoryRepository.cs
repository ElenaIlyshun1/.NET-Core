using ShopPhone.Main.Interfaces;
using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.Repository
{
    public class MotherboardCategoryRepository : IMotherboardsCategory
    {
        private readonly DBContent dbContent;
        public MotherboardCategoryRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<MotherboardCategory> AllMotherboardsCategories => dbContent.MotherboardCategories;

       
    }
}
