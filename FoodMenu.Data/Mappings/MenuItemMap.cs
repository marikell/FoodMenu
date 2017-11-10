using FoodMenu.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Data.Mappings
{
    public class MenuItemMap: EntityTypeConfiguration<MenuItem>
    {
        public MenuItemMap()
        {
            HasKey(u => u.IdMenuItem);
            Property(t => t.NamMenuItem).HasMaxLength(60);
            Property(t => t.DesMenuItem).HasMaxLength(255);
            HasRequired(u => u.MenuHeader);

        }
    }
}
