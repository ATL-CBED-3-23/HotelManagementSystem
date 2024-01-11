using HotelAPI.Application.DTOs.Rooms;

namespace HotelAPI.Application.DTOs.RoomTypes
{
    public class RoomTypeTableResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relations
        public List<RoomTableResponse> Rooms { get; set; }

    }
}
