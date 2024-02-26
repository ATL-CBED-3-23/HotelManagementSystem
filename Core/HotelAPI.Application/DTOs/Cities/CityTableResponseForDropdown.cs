using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Cities
{
    public class CityTableResponseForDropdown : IMapTo<City>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
