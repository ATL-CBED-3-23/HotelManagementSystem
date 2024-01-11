using HotelAPI.Application.DTOs.Reservations;

namespace HotelAPI.Application.DTOs.Reservators
{
    public class ReservatorTableResponse 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        //Relations
        public List<ReservationTableResponse> Reservations { get; set; }
        public List<ReviewTableResponse> Reviews { get; set; }

    }

}
