using HotelAPI.Application.DTOs.HotelUserImages;
using HotelAPI.Application.DTOs.HotelUserRoles;

namespace HotelAPI.Application.DTOs.HotelUsers
{
    public class UserTableResponse
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public List<string> Roles { get; set; }
        public NetworkStatus NetworkStatus { get; set; }
        public HotelUserImageTableResponse HotelUserImage { get; set; }

    }
}