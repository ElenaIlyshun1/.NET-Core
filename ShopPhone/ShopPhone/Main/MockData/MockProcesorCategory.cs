using ShopPhone.Main.Interfaces;
using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.MockData
{
    public class MockProcesorCategory : IProcesorCategory
    {
        public IEnumerable<ProcesorCategory> AllProcesorsCategories
        {
            get
            {
                return new List<ProcesorCategory>
                {
                    new ProcesorCategory {categoryName = "Flagman", categoryDescription = "Procesor with low path"},
                    new ProcesorCategory {categoryName = "Budget", categoryDescription = "Procesor with hight path"}
                };
            }
        }
    }
}
