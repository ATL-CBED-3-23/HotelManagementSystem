using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.HotelUserRoles
{
    public class RoleTableResponse:IMapTo<HotelUserRole>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
