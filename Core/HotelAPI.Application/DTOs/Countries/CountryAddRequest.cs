using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Countries
{
    public class CountryAddRequest : IMapTo<Country>
    {
        public string Name { get; set; }
    }
}
