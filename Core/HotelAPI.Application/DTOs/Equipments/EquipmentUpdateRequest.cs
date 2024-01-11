using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Equipments
{
    public class EquipmentUpdateRequest : IMapTo<Equipment>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        //Relations
        public int RoomId { get; set; }
    }
}
