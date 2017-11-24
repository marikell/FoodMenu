using FoodMenu.Core;
using FoodMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodMenu.Controllers
{
    public class MenuController : Controller
    {
        private MenuCore Core;

        public MenuController()
        {
            Core = new MenuCore();
        }

        public ActionResult Create(int id = 0)
        {
            return RedirectToAction("Menu", "Menu", new { IDRestaurant = id });
        }

        public ActionResult Menu(int IDRestaurant)
        {
            Menu Menu = new Menu { IdRestaurant = IDRestaurant };
            return View(Menu);
        }

        public ActionResult GetMenusByRestaurant(int IDRestaurant)
        {
            ICollection<Menu> Menus = Core.GetMenusByRestaurant(IDRestaurant);
            return Json(Menus.Select(u => new Menu { IdMenu = u.IdMenu, NamMenu = u.NamMenu, DesMenu = u.DesMenu }).ToList(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreateMenu(Menu Menu)
        {
            Core.CreateMenu(Menu);
            return View("Index","Menu", Core.GetRestaurantById(Menu.IdRestaurant));
        }

        public ActionResult AddMenuItem(MenuItem MenuItem, int IDRestaurant)
        {

            Core.AddMenuItem(MenuItem);
            return RedirectToAction("Index", "Menu");
        }


        public ActionResult AddMenuHeader(MenuHeader MenuHeader, int IDRestaurant)
            {

            Core.AddMenuHeader(MenuHeader);
            return RedirectToAction("Index", "Menu");
        }

        public ActionResult Index(int id)
        {
            Restaurant Restaurant = Core.GetRestaurantById(id);

            return View(Restaurant);
        }

        //public ActionResult GetMenusByRestaurant(int id)
        //{
        //    Restaurant Restaurant = Core.GetRestaurantById(id);
        //    return Json(Restaurant.Menus, JsonRequestBehavior.AllowGet);

        //}

    }
}