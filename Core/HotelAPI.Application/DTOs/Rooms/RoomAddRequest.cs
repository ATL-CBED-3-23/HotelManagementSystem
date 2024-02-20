using HotelAPI.Application.DTOs.RoomImages;
using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;
using System.Security.Principal;

namespace HotelAPI.Application.DTOs.Rooms
{
    public class RoomAddRequest : IMapTo<Room>
    {
        public int Number { get; set; }
        public int Floor { get; set; }
        public string Phone { get; set; }
        public double Price { get; set; }
        public RoomState RoomState { get; set; }
        public List<int> EquipmentIds { get; set; }

        //Relations

        public int RoomTypeId { get; set; }
        public int HotelId { get; set; }
        public List<RoomImageAddRequest> RoomImages { get; set; }

    }
}
