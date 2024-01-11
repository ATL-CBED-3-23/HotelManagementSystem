using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.DTOs.Countries;

namespace HotelAPI.Application.Services.Abstract
{
    public interface ICityService
    {
        Task AddAsync(CityAddRequest createCityDto);

    }
}
