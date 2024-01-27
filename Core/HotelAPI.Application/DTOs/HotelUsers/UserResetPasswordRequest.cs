using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.HotelUsers
{
    public class UserResetPasswordRequest : IMapTo<HotelUser>
    {
        public int Id { get; set; }
        public string NewPassword { get; set; }
    }
}
