using HotelAPI.Application.DTOs.Reservators;
using HotelAPI.Application.DTOs.Rooms;

namespace HotelAPI.Application.DTOs.Reservations
{
    public class ReservationTableResponse 
    {
        public int Id { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        //Relations
        public RoomTableResponse Room { get; set; }
        public ReservatorTableResponse Reservator { get; set; }

    }
}
