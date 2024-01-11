using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Equipments
{
    public class EquipmentTableResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        //Relations
        public Room Room { get; set; }
    }
}
