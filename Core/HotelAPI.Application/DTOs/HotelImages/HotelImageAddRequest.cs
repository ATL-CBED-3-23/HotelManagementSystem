using HotelAPI.Application.Helpers;
using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System.Text.Json.Serialization;

namespace HotelAPI.Application.DTOs.HotelImages
{
    public class HotelImageAddRequest : IMapTo<HotelImage>
    {
        public string FileName { get; set; }
        [JsonIgnore]
        public string FilePath { get; set; } = FileServerPath.Path;
        public string FileBase64 { get; set; }

        //Relations
        [JsonIgnore]
        public int HotelId { get; set; }
    }
}
