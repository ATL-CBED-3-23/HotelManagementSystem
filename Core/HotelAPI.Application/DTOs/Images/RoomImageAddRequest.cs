using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace HotelAPI.Application.DTOs.Images
{
    public class RoomImageAddRequest : IMapTo<RoomImage>
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public IFormFile File { get; set; }

        //Relations
        public int RoomId { get; set; }
    }
}
