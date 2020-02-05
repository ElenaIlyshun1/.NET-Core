using ShopPhone.Main.Interfaces;
using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.Repository
{
    public class PhoneCategoryRepository : IPhoneCategory
    {
        private readonly DBContent dbContent;
        public PhoneCategoryRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<Category> AllCategories => dbContent.PhoneCategories;
    }
}
