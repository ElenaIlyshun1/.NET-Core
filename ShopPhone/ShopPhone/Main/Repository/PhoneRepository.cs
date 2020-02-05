using Microsoft.EntityFrameworkCore;
using ShopPhone.Main.Interfaces;
using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.Repository
{
    public class PhoneRepository : IAllPhones
    {
        private readonly DBContent dbContent;
        public PhoneRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<Phone> phones => dbContent.Phone.Include(c => c.Category);
    }
}
