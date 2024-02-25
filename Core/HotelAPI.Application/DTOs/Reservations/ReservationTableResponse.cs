using HotelAPI.Application.DTOs.HotelUsers;
using HotelAPI.Application.DTOs.Rooms;
using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Reservations
{
    public class ReservationTableResponse : IMapTo<Reservation>
    {
        public int Id { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        //Relations
        public RoomTableResponse Room { get; set; }
        public UserTableResponse HotelUser { get; set; }

    }
}
