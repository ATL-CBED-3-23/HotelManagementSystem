using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.HotelRatings
{
    public class HotelRatingAddRequest : IMapTo<HotelRating>
    {

        public Rating Rating { get; set; }
        public int HotelId { get; set; }
        public int UserId { get; set; }

    }
}
