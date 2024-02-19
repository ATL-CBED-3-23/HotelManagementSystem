using HotelAPI.Application.DTOs.Cities;

namespace HotelAPI.Application.DTOs.Countries
{
    public class CountryTableResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Relations
       
        public List<CityTableResponse> Cities { get; set; }

       
    }
}
