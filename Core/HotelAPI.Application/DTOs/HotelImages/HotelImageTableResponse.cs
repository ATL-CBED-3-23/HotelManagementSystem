using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;
using System.Text.Json.Serialization;

namespace HotelAPI.Application.DTOs.HotelImages
{
    public class HotelImageTableResponse : IMapTo<HotelImage>
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public FileType FileType { get; set; }
        [JsonIgnore]
        public string? FilePath { get; set; }
        public string File { get; set; }

        //Relations
        [JsonIgnore]
        public int? HotelId { get; set; }
    }
}
