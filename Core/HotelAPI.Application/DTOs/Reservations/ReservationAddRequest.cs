using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Reservations
{
    public class ReservationAddRequest : IMapTo<Reservation>
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        //Relations
        public int RoomId { get; set; }
        public int ReservatorId { get; set; }

    }
}
