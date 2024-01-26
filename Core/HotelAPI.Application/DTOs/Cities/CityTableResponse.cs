using HotelAPI.Application.DTOs.Countries;
using HotelAPI.Application.DTOs.Hotels;
using HotelAPI.Domain.Entities;
using System.Text.Json.Serialization;

namespace HotelAPI.Application.DTOs.Cities
{
    public class CityTableResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PostalCode { get; set; }
        [JsonIgnore]
        public string? Country {  get; set; }

        //Relations
         //public CountryTableResponse Country { get; set; }
        public List<HotelTableResponse> HotelTable { get; set; }
    }
}
