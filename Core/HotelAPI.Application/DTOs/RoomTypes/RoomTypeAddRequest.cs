using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.RoomTypes
{
    public class RoomTypeAddRequest : IMapTo<RoomType>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //Relations

    }
}
