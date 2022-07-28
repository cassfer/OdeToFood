using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "Kireina", Location="Vila Regina", Cuisine=CuisineType.Japanese},
                new Restaurant {Id = 2, Name = "Juliete", Location = "Conjunto Primavera", Cuisine=CuisineType.Pizzeria},
                new Restaurant {Id = 3, Name = "Cleiton Burger", Location = "Residencial Triunfo", Cuisine=CuisineType.Hamburger}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                    select r;
        }
    }
}
