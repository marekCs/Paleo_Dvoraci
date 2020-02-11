using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paleo_ClassLibrary.Models
{
    public class Recipe
    {
        public List<int> IngredientsID { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; } // the URL
        public int ProtocolID { get; set; }
        public string Text { get; set; }
    }
}
