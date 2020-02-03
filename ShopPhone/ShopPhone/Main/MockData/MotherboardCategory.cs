using ShopPhone.Main.Interfaces;
using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPhone.Main.Interfaces;

namespace ShopPhone.Main.MockData
{
    public class MotherboardCategory : IMotherboardsCategory
    {
        public IEnumerable<MotherboardCategory> AllMotherboardsCategories
        {
            get
            {
                return new List<MotherboardCategory>
                {
                    //new MotherboardCategory {categoryName = "Flagman", categoryDescription = "Motherboard with low path"},
                    //new MotherboardCategory {categoryName = "Budget", categoryDescription = "Motherboard with hight path"}
                };
            }
        }
    }
}