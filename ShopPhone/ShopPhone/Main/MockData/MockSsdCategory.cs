using ShopPhone.Main.Interfaces;
using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.MockData
{
    public class MockSsdCategory : ISsdCategory
    {
        public IEnumerable<SsdCategory> AllSsdsCategories
        {
            get
            {
                return new List<SsdCategory>
                {
                    new SsdCategory {categoryName = "Flagman", categoryDescription = "Ssd with low path"},
                    new SsdCategory {categoryName = "Budget", categoryDescription = "Ssd with hight path"}
                };
            }
        }
    }
}
