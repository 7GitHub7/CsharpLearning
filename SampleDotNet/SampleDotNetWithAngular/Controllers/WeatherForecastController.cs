using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SampleDotNetWithAngular.Entities;
using SampleDotNetWithAngular.Models;
using SampleDotNetWithAngular.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDotNetWithAngular.Controllers
{
    // check if defined in dto model, attributes are passed
    [ApiController]

    public class WeatherForecastController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;
        
      

        public WeatherForecastController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }


        [Route("api/restaurant/{id}")]
        [HttpPut]
        public ActionResult Update([FromBody] UpdateResultsDto dto,[FromRoute] int id)
        {
           

            _restaurantService.Update(id,dto);
            return Ok();

        }

        [Route("api/restaurant/{id}")]
        [HttpDelete]
        public ActionResult Delete([FromRoute] int id)
        {

            _restaurantService.Delete(id);

            return NotFound();

        }
        [Route("api/restaurant")]
        [HttpGet]
        public ActionResult<IEnumerable<RestaurantDTO>> GetAll()
        {

            var restaurantsDtos = _restaurantService.GetAll();
            return Ok(restaurantsDtos);
         
        }

        [Route("api/restaurant/{id}")]
        [HttpGet]
        public ActionResult<IEnumerable<RestaurantDTO>> Get([FromRoute] int id)
        {

            var restaurantDtos = _restaurantService.GetById(id);       
            return Ok(restaurantDtos);

        }

        
        
      //  [Route("api/restaurant")]
        [HttpPost("api/restaurant")]
        public ActionResult CreateRestaurant([FromBody] CreateRestaurantDto dto)
        {
           
            var id = _restaurantService.Create(dto);

            return Created($"/api/restaurant/{id}", null);
        }

    }
}
