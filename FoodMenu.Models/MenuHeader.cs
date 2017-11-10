using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Models
{
    public class MenuHeader
    {
        public int IdMenuHeader { get; set; }
        public string NamMenuHeader { get; set; }
        public string DesMenuHeader { get; set; }
        public int ValSequence { get; set; }
        public virtual ICollection<MenuItem> MenuItems { get; set; }
        public int IdMenu { get; set; }
        public Menu Menu { get; set; }
    }
}
