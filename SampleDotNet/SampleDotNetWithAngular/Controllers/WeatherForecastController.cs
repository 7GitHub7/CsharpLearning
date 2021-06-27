using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SampleDotNetWithAngular.Entities;
using SampleDotNetWithAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDotNetWithAngular.Controllers
{
    [ApiController]

    public class WeatherForecastController : ControllerBase
    {
        private readonly RestaurantDBContext _DBContext;
        private readonly IMapper _mapper;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, RestaurantDBContext DBContext, IMapper mapper)
        {
            _logger = logger;
            _DBContext = DBContext;
            _mapper = mapper;
        }
        [Route("[controller]")]
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [Route("api/restaurant")]
        [HttpGet]
        public ActionResult<IEnumerable<RestaurantDTO>> GetAll()
        {

            var restaurants =
                _DBContext
                .Restaurants
                .Include(r => r.Address)
                .Include(r => r.Dishes)
                .ToList();
            var restaurantsDTOs = _mapper.Map<List<RestaurantDTO>>(restaurants);
            return Ok(restaurantsDTOs);

        }

        [Route("api/restaurant/{id}")]
        [HttpGet]
        public ActionResult<IEnumerable<RestaurantDTO>> GetAll([FromRoute] int id)
        {

            var restaurant = _DBContext
                .Restaurants
                .Include(r => r.Address)
                .Include(r => r.Dishes)
                .FirstOrDefault(r => r.Id == id);

            if (restaurant is null) return NotFound();
            var restaurantDto = _mapper.Map<RestaurantDTO>(restaurant);
            return Ok(restaurantDto);

        }


        [HttpPost] ActionResult CreateRestaurant([FromBody])

    }
}
