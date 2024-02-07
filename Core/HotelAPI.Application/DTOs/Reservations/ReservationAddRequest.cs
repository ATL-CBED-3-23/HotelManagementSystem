using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;
using System.Text.Json.Serialization;

namespace HotelAPI.Application.DTOs.Reservations
{
    public class ReservationAddRequest : IMapTo<Reservation>
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        //Relations
        public int RoomId { get; set; }
        [JsonIgnore]
        public int HotelUserId { get; set; }

    }
}
