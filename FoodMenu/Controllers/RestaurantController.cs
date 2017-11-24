using FoodMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FoodMenu.Core;
using System.Web.Mvc;
using System.Net;

namespace FoodMenu.Controllers
{
    public class RestaurantController: Controller
    {
        private RestaurantCore Core;

        public RestaurantController(){

            Core = new RestaurantCore();
        }
        public ActionResult Home()
        {
            return View();
        }

        public virtual ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Restaurant Restaurant, int IdRestaurant)
        {
            Restaurant.IdRestaurant = IdRestaurant;
            Core.Edit(Restaurant);
            return RedirectToAction("Index", "Restaurant");

        }

        public ActionResult Register(int id = 0)
        {
            if(id == 0)
            return View(new Restaurant());
            else
                return View(Core.GetRestaurantById(id));
        }

        public ActionResult Info(int id)
        {
            Restaurant Restaurant = Core.GetRestaurantById(id);
            return View("Register", Restaurant);

        }

        [HttpPost]
        public ActionResult Create(Restaurant Restaurant)
        {
            
                Core.Create(Restaurant);
           
            return RedirectToAction("Index", "Restaurant");
        }

        public ActionResult GetAllRestaurants()
        {
            ICollection<Restaurant> Restaurants = Core.GetAllRestaurants();

            return Json(Restaurants.Select(u=> new Restaurant { IdRestaurant = u.IdRestaurant, NamRestaurant = u.NamRestaurant, Menus = u.Menus.Select(g => new Menu { IdMenu = g.IdMenu, NamMenu = g.NamMenu}).ToList()}), JsonRequestBehavior.AllowGet);
        }


       public ActionResult Restaurant(int id)
        {
            Restaurant Restaurant = Core.GetRestaurantById(id);
            return View(Restaurant);
        }

    }
}