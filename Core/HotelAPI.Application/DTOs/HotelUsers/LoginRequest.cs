using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.HotelUsers
{
    public class LoginRequest:IMapTo<HotelUser>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
