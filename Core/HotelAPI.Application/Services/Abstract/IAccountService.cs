using HotelAPI.Application.DTOs.HotelUserRoles;
using HotelAPI.Application.DTOs.HotelUsers;
using HotelAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IAccountService
    {
        Task<IdentityResult> RegisterUserAsync(UserAddRequest userAddRequest);
        Task<IdentityResult> CreateRoleAsync(RoleAddRequest roleAddRequest);
        Task<List<HotelUserRole>> GetAllRolesAsync();
    }
}
