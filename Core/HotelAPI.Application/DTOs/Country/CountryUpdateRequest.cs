using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Countries
{
    public class CountryUpdateRequest : IMapTo<Country>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
