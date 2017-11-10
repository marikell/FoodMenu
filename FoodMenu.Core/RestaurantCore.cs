using FoodMenu.Data;
using FoodMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Core
{
   public class RestaurantCore: FoodMenuCoreBase<Restaurant>
    {
        private RestaurantRepository Repository { get { return (RestaurantRepository)FRepository; } }


    }
}
