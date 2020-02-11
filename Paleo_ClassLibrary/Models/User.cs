using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paleo_ClassLibrary.Models
{
    public class User
    {
        public int ID { get; set; } = 0;
        public int UserID { get { return ID; } }
        public string Name { get; set; }
        public int AllergyID { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}
