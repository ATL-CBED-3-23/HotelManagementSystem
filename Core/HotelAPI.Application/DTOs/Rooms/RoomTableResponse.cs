using HotelAPI.Application.DTOs.Reservations;

namespace HotelAPI.Application.DTOs.Rooms
{
    public class RoomTableResponse 
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Floor { get; set; }
        public string Phone { get; set; }
        public double Price { get; set; }
        public RoomState RoomState { get; set; } = RoomState.Available;

        //Relations
        public RoomTypeTableResponse RoomType { get; set; }
        public RoomTypeTableResponse Hotel { get; set; }
        public List<EquipmentTableResponse> Equipments { get; set; }
        public List<ReservationTableResponse> Reservations { get; set; }

    }
}
