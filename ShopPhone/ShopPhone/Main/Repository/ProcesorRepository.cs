using Microsoft.EntityFrameworkCore;
using ShopPhone.Main.Interfaces;
using ShopPhone.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.Repository
{
    public class ProcesorRepository : IAllProcesors
    {
        private readonly DBContent dbContent;
        public ProcesorRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<Procesor> procesors => dbContent.Procesors.Include(c => c.ProcesorCategory);
    }
}
