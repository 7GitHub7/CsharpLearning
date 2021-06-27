using SampleDotNetWithAngular.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDotNetWithAngular
{
    public class RestaurantSeeder
    {
        private readonly RestaurantDBContext _dBContext;

        public RestaurantSeeder(RestaurantDBContext restaurantDBContext)
        {
            _dBContext = restaurantDBContext;
        }
        public void Seed()
        {
            if (_dBContext.Database.CanConnect())
            {
                if (!_dBContext.Restaurants.Any())
                {
                    var restaurants = GetRestaurants();
                    _dBContext.Restaurants.AddRange(restaurants);
                    _dBContext.SaveChanges();
                }
            }
        }
        private IEnumerable<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>() {
            new Restaurant()
            {
                Name = "KFC",
                Category = "Fast Food",
                Description = "test",
                ContactEmail = "ww@onet.pl",
                HasDelivery = true,
                Dishes = new List<Dish>()
                {
                    new Dish()
                    {
                        Name = "Pierogi",
                        Price = 5.3M,
                    },
                    new Dish()
                    {
                        Name = "Kapusta",
                        Price = 3M,
                    },
                },

                Address = new Address()
                {
                    City = "Warszawa",
                    Street = "Nowa",
                    PostalCode = "9999"
                }
            },

            new Restaurant()
            {
                Name = "MCDonalds",
                Category = "Fast Food",
                Description = "test",
                ContactEmail = "mc@onet.pl",
                HasDelivery = true,
                Dishes = new List<Dish>()
                {
                    new Dish()
                    {
                        Name = "Hamburger",
                        Price = 5.3M,
                    },
                    new Dish()
                    {
                        Name = "Kotlet",
                        Price = 3M,
                    },
                },

                Address = new Address()
                {
                    City = "Lublin",
                    Street = "StaryRynek",
                    PostalCode = "3333"
                }
            }
            };
            return restaurants;
        }
    }
}
