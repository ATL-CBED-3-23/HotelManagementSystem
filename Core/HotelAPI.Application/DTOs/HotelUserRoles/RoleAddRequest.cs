using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.HotelUserRoles
{
    public class RoleAddRequest:IMapTo<HotelUserRole>
    {
        public string Name { get; set; }
    }
}
