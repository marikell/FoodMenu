using FoodMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMenu.Data
{
    public class MenuHeaderRepository: FoodMenuRepositoryBase<MenuHeader>
    {
        public static void AddMenuHeader(FoodMenuContext Context, MenuHeader MenuHeader)
        {
            Context.MenuHeaders.Add(MenuHeader);
            Context.SaveChanges();
        }

    }
}
