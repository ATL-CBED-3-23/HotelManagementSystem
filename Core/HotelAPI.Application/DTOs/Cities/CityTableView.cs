using HotelAPI.Application.DTOs.Countries;
using HotelAPI.Application.DTOs.Hotels;

namespace HotelAPI.Application.DTOs.Cities
{
    public class CityTableView
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Relations
        public CountryTableResponse Country { get; set; }
        public List<HotelTableResponse> HotelTable { get; set; }

    }
}
