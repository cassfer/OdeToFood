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
        IEnumerable<Restaurant> GetRestaurantsByName(string? name = null);
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
        public IEnumerable<Restaurant> GetRestaurantsByName(string? name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.ToUpper().Contains(name.ToUpper())
                   orderby r.Name
                    select r;
        }
    }
}
