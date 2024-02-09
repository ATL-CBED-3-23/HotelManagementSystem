using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace HotelAPI.Application.DTOs.HotelImages
{
    public class HotelImageAddRequest : IMapTo<HotelImage>
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public IFormFile File { get; set; }

        //Relations
        public int HotelId { get; set; }
    }
}
