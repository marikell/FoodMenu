using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Models
{
    public class Menu
    {
        public int IdMenu { get; set; }
        public string NamMenu { get; set; }
        public string DesMenu { get; set; }
        public virtual ICollection<MenuHeader> MenuHeaders { get; set; }
        public int IdRestaurant { get; set; }
        public Restaurant Restaurant { get; set; }

    }
}
