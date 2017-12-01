using FoodMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Data
{
    public class MenuRepository: FoodMenuRepositoryBase<Menu>
    {
        protected FoodMenuContext Context;

        public MenuRepository()
        {
            Context = new FoodMenuContext();
        }
        public Restaurant GetRestaurantById(int id)
        {
            return RestaurantRepository.GetRestaurantById(Context, id);
        }

        public MenuHeader GetMenuHeaderById(int IDHeader)
        {
            return MenuHeaderRepository.GetMenuHeaderById(Context, IDHeader);
        }

        public ICollection<Menu> GetMenusByRestaurant(int IDRestaurant)
        {
            return Context.Menus.Where(u => u.IdRestaurant == IDRestaurant).ToList();
        }

        public Menu GetMenuById(int id)
        {
            return Context.Menus.Where(u => u.IdMenu == id).FirstOrDefault();
        }
        public void CreateMenu(Menu Menu)
        {
            Context.Menus.Add(Menu);
            Context.SaveChanges();
        }

        public void AddMenuItem(MenuItem MenuItem)
        {
            MenuItemRepository.AddMenuItem(Context, MenuItem);
        }

        public void AddMenuHeader(MenuHeader MenuHeader)
        {
            MenuHeaderRepository.AddMenuHeader(Context,MenuHeader);
        }

    }
}
