using FoodMenu.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Data.Mappings
{
    public class MenuHeaderMap: EntityTypeConfiguration<MenuHeader>
    {
        public MenuHeaderMap()
        {
            HasKey(u => u.IdMenuHeader);
            Property(t => t.NamMenuHeader).HasMaxLength(60);
            Property(t => t.DesMenuHeader).HasMaxLength(255);
            HasMany(u => u.MenuItems).WithRequired(g => g.MenuHeader);
            HasRequired(u => u.Menu).WithMany(v => v.MenuHeaders);


        }
    }
}
