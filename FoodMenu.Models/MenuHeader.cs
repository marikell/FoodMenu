using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Models
{
    public class MenuHeader
    {
        public int IdMenuHeader { get; set; }
        [DisplayName("Nome")]
        public string NamMenuHeader { get; set; }
        [DisplayName("Descrição")]
        public string DesMenuHeader { get; set; }
        [DisplayName("Ordem")]
        public int ValSequence { get; set; }
        [DisplayName("Itens")]
        public virtual ICollection<MenuItem> MenuItems { get; set; }
        public int IdMenu { get; set; }
        [DisplayName("Cardápio")]
        public Menu Menu { get; set; }
    }
}
