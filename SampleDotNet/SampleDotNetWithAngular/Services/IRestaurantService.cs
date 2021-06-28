using SampleDotNetWithAngular.Models;
using System.Collections.Generic;

namespace SampleDotNetWithAngular.Services
{
    public interface IRestaurantService
    {
        int Create(CreateRestaurantDto dto);
        IEnumerable<RestaurantDTO> GetAll();
        RestaurantDTO GetById(int Id);

        bool Delete(int id);
        bool Update(int id, UpdateResultsDto updateResultsDto);
    }
}