using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.HotelUserImages
{
    public class HotelUserImageTableResponse : IMapTo<HotelUserImage>
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public FileType FileType { get; set; }
        public string FilePath { get; set; }
        public string FileBase64 { get; set; }

        //Relations
        public int HotelId { get; set; }
    }
}
