using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Images
{
    public class RoomImageAddRequest : IMapTo<RoomImage>
    {
        //public string ImagePath { get; set; }

        //Relations
        public int RoomId { get; set; }
    }
}
