using ShopPhone.Main.Interfaces;
using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ShopPhone.Main.MockData
{
    public class MockMotherboardCategory : IMotherboardsCategory
    {
        public IEnumerable<MotherboardCategory> AllMotherboardsCategories
        {
            get
            {
                return new List<MotherboardCategory>
                {
                    new MotherboardCategory {categoryName = "Flagman", categoryDescription = "Motherboard with low path"},
                    new MotherboardCategory {categoryName = "Budget", categoryDescription = "Motherboard with hight path"}
                };
            }
        }
    }
}