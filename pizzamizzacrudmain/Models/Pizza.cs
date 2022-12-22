using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzamizzacrudmain.Models
{
    internal class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Size> Sizes { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}
