using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Reviews
{
    public class ReviewAddRequest : IMapTo<Review>
    {
        public string Content { get; set; }

        //Relations
        public int HotelId { get; set; }
    }
}
