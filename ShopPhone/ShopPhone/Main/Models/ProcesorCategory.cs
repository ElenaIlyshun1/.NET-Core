using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.Models
{
    public class ProcesorCategory
    {
        public int Id { set; get; }
        public string categoryName { get; set; }
        public string categoryDescription { get; set; }
        public List<Procesor> procesors { set; get; }
    }
}
