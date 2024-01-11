using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Rooms
{
    public class RoomUpdateRequest : IMapTo<Room>
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Floor { get; set; }
        public string Phone { get; set; }
        public double Price { get; set; }
        public RoomState RoomState { get; set; } 

        //Relations
        //Relations
        public int RoomTypeId { get; set; }
        public int HotelId { get; set; }

    }
}
