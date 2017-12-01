using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Models
{
    public class MenuItem
    {
        public int IdMenuItem { get; set; }
        [DisplayName("Nome do Item")]
        public string NamMenuItem { get; set; }
        [DisplayName("Ordem")]
        public int NumSequence { get; set; }
        [DisplayName("Preço")]
        public double Price { get; set; }
        [DisplayName("Descrição")]
        public string DesMenuItem { get; set; }
        [DisplayName("Cabeçalho")]
        public MenuHeader MenuHeader { get; set; }
        public int IdMenuHeader { get; set; }

    }
}
