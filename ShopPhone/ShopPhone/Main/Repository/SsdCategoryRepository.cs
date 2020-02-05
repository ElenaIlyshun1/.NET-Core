using ShopPhone.Main.Interfaces;
using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.Repository
{
    public class SsdCategoryRepository : ISsdCategory
    {
        private readonly DBContent dbContent;
        public SsdCategoryRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<SsdCategory> AllSsdsCategories => dbContent.SsdCategories;
    }
}
