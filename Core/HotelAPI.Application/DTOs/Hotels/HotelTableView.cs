using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.DTOs.HotelImages;
using HotelAPI.Application.DTOs.Reviews;
using HotelAPI.Application.DTOs.Rooms;
using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Hotels
{
    public class HotelTableView : IMapTo<Hotel>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public Grade Grade { get; set; }

        //Relations
        public CityTableResponse City { get; set; }
        public List<ReviewTableResponse> ReviewTable { get; set; }
        public List<RoomTableResponse> Rooms { get; set; }
        public List<HotelImageTableResponse> HotelImages { get; set; }

    }
}
