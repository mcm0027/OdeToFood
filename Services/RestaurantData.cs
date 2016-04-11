using OdeToFood.Entities;
using System.Collections.Generic;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant {Id = 1, Name = "Emily's" },
                new Restaurant {Id = 2, Name = "Ein Dog's" },
                new Restaurant {Id = 3, Name = "Rowan Cat's" }
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        List<Restaurant> _restaurants;
    }
}
