using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.Hotels
{
    public class HotelTableResponseForDropdown : IMapTo<Hotel>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
