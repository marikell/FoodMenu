using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Models
{
    public class MenuItem
    {
        public int IdMenuItem { get; set; }
        public string NamMenuItem { get; set; }
        public int NumSequence { get; set; }
        public double Price { get; set; }
        public string DesMenuItem { get; set; }
        public MenuHeader MenuHeader { get; set; }
        public int IdMenuHeader { get; set; }

    }
}
