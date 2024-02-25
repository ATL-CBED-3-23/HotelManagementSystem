using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Countries
{
    public class CountryTableView : IMapTo<Country>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Relations       
        public List<CityTableResponse> Cities { get; set; }

    }
}
