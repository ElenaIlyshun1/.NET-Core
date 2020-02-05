using Microsoft.EntityFrameworkCore;
using ShopPhone.Main.Interfaces;
using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.Repository
{
    public class MotherboardRepository : IAllMotherboards
    {
        private readonly DBContent dbContent;
        public MotherboardRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<Motherboard> motherboards => dbContent.Motherboards.Include(c => c.MotherboardCategory);
    }
}
