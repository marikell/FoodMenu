using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Models
{
    public class Restaurant
    {
        public int IdRestaurant { get; set; }
        public string RestaurantUser { get; set; }
        public string RestaurantPassword { get; set; }
        public string NamRestaurant { get; set; }
        public string CNPJ { get; set; }
        public string Address { get; set; }
        public string CEP { get; set; }
        public string DesRestaurant { get; set; }
        public string AddressComplement { get; set; }
        public string Logo { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }

    }
}
