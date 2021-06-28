using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SampleDotNetWithAngular.Entities;
using SampleDotNetWithAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDotNetWithAngular.Services
{
    public class RestaurantService : IRestaurantService
    {
        public readonly RestaurantDBContext _dbContext;
        public readonly IMapper _mapper;
        public RestaurantService(RestaurantDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public bool Update(int id, UpdateResultsDto updateResultsDto)
        {
            var restaurant = _dbContext.Restaurants.FirstOrDefault(r => r.Id == id);
            if (restaurant is null) return false;
            restaurant.Name = updateResultsDto.Name;
            restaurant.Description = updateResultsDto.Description;
            restaurant.HasDelivery = updateResultsDto.hasDelivery;

            _dbContext.SaveChanges();
            return true;
        }
        public bool Delete(int id)
        {
            var restaurant = _dbContext
             .Restaurants
             .FirstOrDefault(r => r.Id == id);

            if(restaurant is null)
            {
                return false;
            }
            _dbContext.Restaurants.Remove(restaurant);
            _dbContext.SaveChanges();

            return true;
        }
        public RestaurantDTO GetById(int Id)
        {
            var restaurant = _dbContext
               .Restaurants
               .Include(r => r.Address)
               .Include(r => r.Dishes)
               .FirstOrDefault(r => r.Id == Id);

            if (restaurant is null) return null;

            var result = _mapper.Map<RestaurantDTO>(restaurant);
            return result;
        }

        public IEnumerable<RestaurantDTO> GetAll()
        {
            var restaurants =
               _dbContext
               .Restaurants
               .Include(r => r.Address)
               .Include(r => r.Dishes)
               .ToList();

            var restaurantsDtos = _mapper.Map<List<RestaurantDTO>>(restaurants);
            return restaurantsDtos;
        }

        public int Create(CreateRestaurantDto dto)
        {


            var restaurant = _mapper.Map<Restaurant>(dto);
            _dbContext.Restaurants.Add(restaurant);
            _dbContext.SaveChanges();

            return restaurant.Id;


        }

       
    }
}
