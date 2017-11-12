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
        public Restaurant GetRestaurantById(int id)
        {
            return RestaurantRepository.GetRestaurantById(Context, id);
        }
    }
}
