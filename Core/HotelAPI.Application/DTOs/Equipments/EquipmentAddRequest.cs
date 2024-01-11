using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Equipments
{
    public class EquipmentAddRequest : IMapTo<Equipment>
    {
        public string Name { get; set; }
        public int Count { get; set; }

        //Relations
        public int RoomId { get; set; }
    }
}
