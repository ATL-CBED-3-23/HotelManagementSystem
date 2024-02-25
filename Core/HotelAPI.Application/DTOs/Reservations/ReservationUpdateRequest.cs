using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Reservations
{
    public class ReservationUpdateRequest : IMapTo<Reservation>
    {
        public int Id { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        //Relations
        public int RoomId { get; set; }

    }
}
