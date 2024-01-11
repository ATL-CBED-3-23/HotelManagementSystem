using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Reviews
{
    public class ReviewUpdateRequest : IMapTo<Review>
    {
        public int Id { get; set; }
        public string Content { get; set; }

        //Relations
        public int ReservatorId { get; set; }
        public int HotelId { get; set; }
    }
}
