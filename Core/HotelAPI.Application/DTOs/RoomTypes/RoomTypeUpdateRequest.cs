using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.RoomTypes
{
    public class RoomTypeUpdateRequest : IMapTo<RoomType>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relations

    }
}
