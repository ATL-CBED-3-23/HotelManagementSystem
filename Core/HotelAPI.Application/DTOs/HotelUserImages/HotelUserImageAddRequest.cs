using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace HotelAPI.Application.DTOs.HotelUserImages
{
    public class HotelUserImageAddRequest : IMapTo<HotelUserImage>
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public IFormFile File { get; set; }

        //Relations
        public int HotelUserId { get; set; }
    }
}
