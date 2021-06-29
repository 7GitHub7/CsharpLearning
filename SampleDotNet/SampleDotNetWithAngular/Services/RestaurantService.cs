using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NLog;
using SampleDotNetWithAngular.Entities;
using SampleDotNetWithAngular.Exceptions;
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
        private readonly ILogger<RestaurantService> _logger;

        public RestaurantService(RestaurantDBContext dbContext, IMapper mapper, ILogger<RestaurantService> logger)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _logger = logger;
        }

        public void Update(int id, UpdateResultsDto updateResultsDto)
        {
            var restaurant = _dbContext.Restaurants.FirstOrDefault(r => r.Id == id);
            if (restaurant is null) 
                throw new NotFoundException("Restaurant not found");
            restaurant.Name = updateResultsDto.Name;
            restaurant.Description = updateResultsDto.Description;
            restaurant.HasDelivery = updateResultsDto.hasDelivery;

            _dbContext.SaveChanges();
            
        }
        public void Delete(int id)
        {
            //using NLog, write to file specified logs
            _logger.LogError($"Restaurant with id: {id} DELETE action invoked");
            var restaurant = _dbContext
             .Restaurants
             .FirstOrDefault(r => r.Id == id);

            if(restaurant is null)
                throw new NotFoundException("Restaurant not found");
            
            _dbContext.Restaurants.Remove(restaurant);
            _dbContext.SaveChanges();

          
        }
        public RestaurantDTO GetById(int Id)
        {
            var restaurant = _dbContext
               .Restaurants
               .Include(r => r.Address)
               .Include(r => r.Dishes)
               .FirstOrDefault(r => r.Id == Id);

            if (restaurant is null)
                throw new NotFoundException("Restaurant not found");

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
