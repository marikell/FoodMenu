using FoodMenu.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Data.Mappings
{
    public class MenuMap: EntityTypeConfiguration<Menu>
    {
        public MenuMap()
        {
            HasKey(u => u.IdMenu);
            Property(t => t.NamMenu).HasMaxLength(60);
            Property(t => t.DesMenu).HasMaxLength(255);
            HasRequired(u => u.Restaurant).WithMany(v => v.Menus);
            HasMany(u => u.MenuHeaders).WithRequired(v => v.Menu);


        }
    }
}
