using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.HotelUsers
{
    public class LoginedUserResponse : IMapTo<HotelUser>
    {
        public string UserFullName { get; set; }
        public string UserName { get; set; }
        public IList<string> UserRoles { get; set; }
        public string SecurityToken { get; set; }
    }
}
