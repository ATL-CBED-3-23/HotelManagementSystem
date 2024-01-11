using HotelAPI.Application.DTOs.Hotels;
using HotelAPI.Application.DTOs.Reservators;

namespace HotelAPI.Application.DTOs.Reviews
{
    public class ReviewTableResponse
    {
        public int Id { get; set; }
        public string Content { get; set; }

        //Relations
        public ReservatorTableResponse Reservator { get; set; }
        public HotelTableResponse Hotel { get; set; }
    }
}
