using FoodMenu.Core;
using FoodMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodMenu.Controllers
{
    public class MenuController: Controller
    {
        private MenuCore Core;

        public MenuController() {

            Core = new MenuCore();
        }

        public ActionResult Create(int id=0)
        {
            return RedirectToAction("Menu", "Menu");
        }

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult Index(int id)
        {
            Restaurant Restaurant = Core.GetRestaurantById(id);

            return View(Restaurant);
        }

        public ActionResult GetMenusByRestaurant(int id)
        {
            Restaurant Restaurant = Core.GetRestaurantById(id);
            return Json(Restaurant.Menus, JsonRequestBehavior.AllowGet);
            
        }

    }
}