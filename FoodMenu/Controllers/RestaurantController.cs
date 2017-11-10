using FoodMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FoodMenu.Core;

namespace FoodMenu.Controllers
{
    public class RestaurantController : FoodMenuControllerBase<Restaurant>
    {
        public RestaurantController() : base(new RestaurantCore()) { }

    }
}