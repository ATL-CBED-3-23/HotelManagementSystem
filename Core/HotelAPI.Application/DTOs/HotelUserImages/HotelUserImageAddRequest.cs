using HotelAPI.Application.Helpers;
using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;
using System.Text.Json.Serialization;

namespace HotelAPI.Application.DTOs.HotelUserImages
{
    public class HotelUserImageAddRequest : IMapTo<HotelUserImage>
    {
        public string FileName { get; set; }
        [JsonIgnore]
        public string FilePath { get; set; } = FileServerPath.Path;
        public string FileBase64 { get; set; }

        //Relations
        [JsonIgnore]
        public int HotelUserId { get; set; }
    }
}
