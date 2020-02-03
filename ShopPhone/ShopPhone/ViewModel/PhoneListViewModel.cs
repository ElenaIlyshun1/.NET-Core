using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.ViewModel
{
    public class PhoneListViewModel
    {
        public IEnumerable<Phone> allPhones { set; get; }
        public string carrentCategory { set; get; }
    }
}
