using ShopPhone.Main.Interfaces;
using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.MockData
{
    public class MockRamCategory : IRamCategory
    {
        public IEnumerable<RamCategory> AllRamsCategories
        {
            get
            {
                return new List<RamCategory>
                {
                    new RamCategory {categoryName = "Flagman", categoryDescription = "Ram with low path"},
                    new RamCategory {categoryName = "Budget", categoryDescription = "Ram with hight path"}
                };
            }
        }
    }
}
