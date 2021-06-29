using SampleDotNetWithAngular.Models;
using System.Collections.Generic;

namespace SampleDotNetWithAngular.Services
{
    public interface IRestaurantService
    {
        int Create(CreateRestaurantDto dto);
        IEnumerable<RestaurantDTO> GetAll();
        RestaurantDTO GetById(int Id);

        void Delete(int id);
        void Update(int id, UpdateResultsDto updateResultsDto);
    }
}