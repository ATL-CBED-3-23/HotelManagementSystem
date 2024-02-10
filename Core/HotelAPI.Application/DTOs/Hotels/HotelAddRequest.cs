using HotelAPI.Application.DTOs.HotelImages;
using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Hotels
{
    public class HotelAddRequest : IMapTo<Hotel>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public Grade Grade { get; set; }

        public HotelImageAddRequest HotelImages { get; set; }

        //Relations
        public int CityId { get; set; }


    }
}
