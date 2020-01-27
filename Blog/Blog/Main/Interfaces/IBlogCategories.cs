using Blog.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Main.Interfaces
{
    public class IBlogCategories
    {
        IEnumerable<Category> allCategories { get; }
    }
}
