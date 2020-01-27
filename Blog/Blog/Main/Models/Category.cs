using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Main.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }

        public List<User> users { get; set; } 
    }
}
