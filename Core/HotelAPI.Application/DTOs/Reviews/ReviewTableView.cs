using HotelAPI.Application.DTOs.Hotels;
using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Reviews
{
    public class ReviewTableView : IMapTo<Review>
    {
        public int Id { get; set; }
        public string Content { get; set; }

        //Relations
        public HotelTableResponse Hotel { get; set; }
    }
}
