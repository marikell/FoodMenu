using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Models
{
    public class Menu
    {
        public int IdMenu { get; set; }
        [DisplayName("Nome")]
        public string NamMenu { get; set; }
        [DisplayName("Descricao")]
        public string DesMenu { get; set; }
        [DisplayName("Cabeçalhos")]    
        public virtual ICollection<MenuHeader> MenuHeaders { get; set; }
        public int IdRestaurant { get; set; }
        [DisplayName("Restaurante")]
        public Restaurant Restaurant { get; set; }

    }
}
