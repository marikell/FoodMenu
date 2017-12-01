using FoodMenu.Data;
using FoodMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Core
{
    public class MenuCore
    {
        private MenuRepository Repository;

        public MenuCore()
        {
            Repository = new MenuRepository();
        }

        public void CreateMenu(Menu Menu)
        {
            Repository.CreateMenu(Menu);
        }

        public MenuHeader GetMenuHeaderById(int IDMenuHeader)
        {
            return Repository.GetMenuHeaderById(IDMenuHeader);
        }

        public ICollection<Menu> GetMenusByRestaurant(int IDRestaurant)
        {

            return Repository.GetMenusByRestaurant(IDRestaurant);
        }

        public void AddMenuHeader(MenuHeader MenuHeader)
        {
            Repository.AddMenuHeader(MenuHeader);
        }

        public void AddMenuItem(MenuItem MenuItem)
        {
            Repository.AddMenuItem(MenuItem);
        }
        public Restaurant GetRestaurantById(int id)
        {
            return Repository.GetRestaurantById(id);
        }

        public Menu GetMenuById(int id)
        {
            return Repository.GetMenuById(id);
        }


 }
}
