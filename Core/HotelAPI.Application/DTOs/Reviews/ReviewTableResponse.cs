using HotelAPI.Application.DTOs.Hotels;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Reviews
{
    public class ReviewTableResponse
    {
        public int Id { get; set; }
        public string Content { get; set; }

        //Relations
        public HotelTableResponse Hotel { get; set; }
    }
}
