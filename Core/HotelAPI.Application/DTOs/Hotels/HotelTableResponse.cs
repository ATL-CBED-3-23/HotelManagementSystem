using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.DTOs.Reviews;
using HotelAPI.Application.DTOs.Rooms;

namespace HotelAPI.Application.DTOs.Hotels
{
    public class HotelTableResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public Grade Grade { get; set; }
        public string City {  get; set; }

        //Relations
      // public CityTableResponse City { get; set; }
        public List<ReviewTableResponse> Reviews { get; set; }
        public List<RoomTableResponse> Rooms { get; set; }

    }
}
