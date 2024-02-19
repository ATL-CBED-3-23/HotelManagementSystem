using HotelAPI.Application.DTOs.HotelUserImages;
using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.HotelUsers
{
    public class UserUpdateRequest : IMapTo<HotelUser>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public IList<string> Roles { get; set; }
        public List<HotelUserImageAddRequest> HotelUserImages { get; set; }

    }
}
