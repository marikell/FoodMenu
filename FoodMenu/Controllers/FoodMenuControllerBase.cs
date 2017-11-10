using FoodMenu.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodMenu.Controllers
{
    public class FoodMenuControllerBase<TEntity>: Controller where TEntity: class, new()
    {
        protected readonly FoodMenuCoreBase<TEntity> Core;

        public FoodMenuControllerBase(FoodMenuCoreBase<TEntity> Core)
        {
            this.Core = Core;
        }

        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult Create()
        {
            return View();
        }
    }
}