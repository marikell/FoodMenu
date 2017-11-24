using FoodMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Data
{
    public class MenuItemRepository: FoodMenuRepositoryBase<MenuItem>
    {
        protected FoodMenuContext Context;

        public MenuItemRepository()
        {
            Context = new FoodMenuContext();
        }

        public static void AddMenuItem(FoodMenuContext Context, MenuItem MenuItem)
        {
            Context.MenuItems.Add(MenuItem);
            Context.SaveChanges();
        }
    }
}
