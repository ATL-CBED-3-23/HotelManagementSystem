using HotelAPI.Application.DTOs.Equipments;
using HotelAPI.Application.DTOs.Hotels;
using HotelAPI.Application.DTOs.Reservations;
using HotelAPI.Application.DTOs.RoomImages;
using HotelAPI.Application.DTOs.RoomTypes;
using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Rooms
{
    public class RoomTableView : IMapTo<Room>
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Floor { get; set; }
        public string Phone { get; set; }
        public double Price { get; set; }
        public RoomState RoomState { get; set; } = RoomState.Available;

        //Relations
        public RoomTypeTableResponse RoomType { get; set; }
        public HotelTableResponse Hotel { get; set; }
        public List<EquipmentTableResponse> Equipments { get; set; }
        public List<ReservationTableResponse> Reservations { get; set; }
        public List<RoomImageTableResponse> RoomImages { get; set; }

    }
}
