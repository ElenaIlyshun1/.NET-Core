using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.ViewModel
{
    public class ProcesorListViewModel
    {
        public IEnumerable<Procesor> allProcesors { set; get; }
        public string currentCategory { set; get; }
    }
}
