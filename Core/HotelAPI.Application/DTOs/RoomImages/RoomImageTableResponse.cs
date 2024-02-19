using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.RoomImages
{
    public class RoomImageTableResponse : IMapTo<RoomImage>
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public FileType FileType { get; set; }
        public string FileBase64 { get; set; }

        //Relations
        public int RoomId { get; set; }
    }
}
