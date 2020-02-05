using Microsoft.EntityFrameworkCore;
using ShopPhone.Main.Interfaces;
using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.Repository
{
    public class SsdRepository : IAllSsd
    {
        private readonly DBContent dbContent;
        public SsdRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<Ssd> ssds => dbContent.Ssds.Include(c => c.SsdCategory);
    }
}
