using HotelAPI.Application.DTOs.HotelUsers;
using HotelAPI.Application.DTOs.Rooms;

namespace HotelAPI.Application.DTOs.Reservations
{
    public class ReservationTableResponse 
    {
        public int Id { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public int Room { get; set; }
        public string HotelUser { get; set; }

        //Relations
        //public RoomTableResponse Room { get; set; }
        //public UserTableResponse HotelUser { get; set; }

    }
}
