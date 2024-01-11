using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Cities
{
    public class CityAddRequest : IMapTo<City>
    {
        public string Name { get; set; }
        public string PostalCode { get; set; }


    }
}
