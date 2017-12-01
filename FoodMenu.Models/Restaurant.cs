using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Models
{
    public class Restaurant
    {
        public int IdRestaurant { get; set; }
        [DisplayName("Nome")]
        public string NamRestaurant { get; set; }
        public string CNPJ { get; set; }
        [DisplayName("Endereço")]
        public string Address { get; set; }
        public string CEP { get; set; }
        [DisplayName("Descrição")]
        public string DesRestaurant { get; set; }
        [DisplayName("Complemento")]
        public string AddressComplement { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }

    }
}
