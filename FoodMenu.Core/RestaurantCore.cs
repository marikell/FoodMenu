using FoodMenu.Data;
using FoodMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Core
{
   public class RestaurantCore
    {
        private RestaurantRepository Repository;

        public RestaurantCore()
        {
            Repository = (RestaurantRepository) new RestaurantRepository();
        }

        public void Create(Restaurant Restaurant)
        {
            Repository.Add(Restaurant);

        }


        public void Edit(Restaurant Restaurant)
        {
            Repository.Edit(Restaurant);
        }

        public Restaurant GetRestaurantById(int id)
        {
            return Repository.GetRestaurantById(id);
        }
        public ICollection<Restaurant> GetAllRestaurants()
        {
            return Repository.GetAllRestaurants();
        }


    }
}
