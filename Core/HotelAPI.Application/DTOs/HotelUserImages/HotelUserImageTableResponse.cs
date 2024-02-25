using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.HotelUserImages
{
    public class HotelUserImageTableResponse : IMapTo<HotelUserImage>
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileBase64 { get; set; }

        //Relations

    }
}
