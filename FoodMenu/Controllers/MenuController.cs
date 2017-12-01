using FoodMenu.Core;
using FoodMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public ActionResult Menu(int id)
        {
            Menu Menu = Core.GetMenuById(id);
            return View("Menu", Menu);
        }

        public ActionResult GetMenusByRestaurant(int IDRestaurant)
        {
            ICollection<Menu> Menus = Core.GetMenusByRestaurant(IDRestaurant);
            return Json(Menus.Select(u => new Menu { IdMenu = u.IdMenu, NamMenu = u.NamMenu, DesMenu = u.DesMenu, IdRestaurant = u.IdRestaurant }).ToList(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreateMenu(Menu Menu)
        {
            Core.CreateMenu(Menu);
            return new HttpStatusCodeResult(HttpStatusCode.OK); 
        }

        public ActionResult AddMenuItem(MenuItem MenuItem, int IDHeader)
        {
            MenuItem.IdMenuHeader = IDHeader;
            Core.AddMenuItem(MenuItem);
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        public ActionResult GetHeadersOfMenu(int IDMenu)
        {
            Menu Menu = Core.GetMenuById(IDMenu);
            Menu.MenuHeaders = Menu.MenuHeaders.Select(u => new MenuHeader {IdMenu = u.IdMenu, DesMenuHeader = u.DesMenuHeader,
            NamMenuHeader = u.NamMenuHeader, IdMenuHeader = u.IdMenuHeader, MenuItems = u.MenuItems.Select(v => new MenuItem {IdMenuItem = v.IdMenuItem,
            DesMenuItem = v.DesMenuItem, IdMenuHeader = v.IdMenuHeader, Price = v.Price, NamMenuItem = v.NamMenuItem, NumSequence = v.NumSequence}).ToList()}).ToList();

            foreach (var item in Menu.MenuHeaders)
            {
                
                item.MenuItems = item.MenuItems.OrderBy(u => u.NumSequence).ToList();
            }


            return Json(Menu.MenuHeaders, JsonRequestBehavior.AllowGet);

        }

        public ActionResult AddMenuHeader(MenuHeader MenuHeader, int IDRestaurant, int IDMenu)
        {
            MenuHeader.IdMenu = IDMenu;
            Core.AddMenuHeader(MenuHeader);
        
            return RedirectToAction("Menu", "Menu", IDMenu);
        }

        public ActionResult Index(int id)
        {
            Restaurant Restaurant = Core.GetRestaurantById(id);

            return View(Restaurant);
        }

     

    }
}