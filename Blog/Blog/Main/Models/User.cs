using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Main.Models
{
    public class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int age { get; set; }
        public int numberPhone { get; set;  }
        public string img { get; set; }
    }
}
