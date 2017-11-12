using FoodMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FoodMenu.Data
{
    public class RestaurantRepository
    {

        protected FoodMenuContext Context;

        public RestaurantRepository()
        {
            Context = new FoodMenuContext();

        }

        public static Restaurant GetRestaurantById(FoodMenuContext Context, int id)
        {
            return Context.Restaurants.Include(u => u.Menus).Where(u => u.IdRestaurant == id).FirstOrDefault();

        }


        public Restaurant Edit(Restaurant Restaurant)
        {

            Restaurant OldRestaurant = Context.Restaurants.Where(u => u.IdRestaurant == Restaurant.IdRestaurant).FirstOrDefault();
            OldRestaurant.NamRestaurant = Restaurant.NamRestaurant;
            OldRestaurant.Menus = Restaurant.Menus;
            OldRestaurant.DesRestaurant = Restaurant.DesRestaurant;
            OldRestaurant.CNPJ = Restaurant.CNPJ;
            OldRestaurant.CEP = Restaurant.CEP;
            OldRestaurant.AddressComplement = Restaurant.AddressComplement;
            OldRestaurant.Address = Restaurant.Address;

            Context.SaveChanges();

            return Restaurant;
        }

       public void Add(Restaurant Restaurant)
        {
            Context.Restaurants.Add(Restaurant);
            Context.SaveChanges();
        }

        public Restaurant GetRestaurantById(int id)
        {
            return GetRestaurantById(Context, id);
        }

        public ICollection<Restaurant> GetAllRestaurants()
        {
            return Context.Restaurants.ToList();
        }

    }
}
