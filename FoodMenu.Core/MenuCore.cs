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
        
        public Restaurant GetRestaurantById(int id)
        {
            return Repository.GetRestaurantById(id);
        }

    }
}
