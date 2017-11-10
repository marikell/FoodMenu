using FoodMenu.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Data.Mappings
{
    public class RestaurantMap: EntityTypeConfiguration<Restaurant>
    {
        public RestaurantMap()
        {
            HasKey(p => p.IdRestaurant);
            Property(t => t.NamRestaurant).HasMaxLength(60);
            Property(t => t.DesRestaurant).HasMaxLength(255);
            //Um restaurante possui vários menus, sendo que este está presente em apenas um restaurante.
            HasMany(p => p.Menus).WithRequired(u => u.Restaurant);

        }
    }
}
