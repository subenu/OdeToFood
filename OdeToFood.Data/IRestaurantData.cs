using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
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
                new Restaurant { Id = 1, Name = "Scott's Pizza", Location = "Maryland", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Sven's Pizza", Location = "Zeewolde", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 3, Name = "Sven's Shushi", Location = "Amersfoort", Cuisine = CuisineType.Indian },
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
