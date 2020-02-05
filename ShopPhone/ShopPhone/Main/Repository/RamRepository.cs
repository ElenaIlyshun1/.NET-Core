using Microsoft.EntityFrameworkCore;
using ShopPhone.Main.Interfaces;
using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.Repository
{
    public class RamRepository : IAllRam
    {
        private readonly DBContent dbContent;
        public RamRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<Ram> rams => dbContent.Rams.Include(c => c.RamCategory);
    }
}
