using HotelAPI.Application.DTOs.HotelUserRoles;
using HotelAPI.Application.DTOs.HotelUsers;
using Microsoft.AspNetCore.Identity;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IAccountService
    {
        Task<IdentityResult> RegisterUserAsync(UserAddRequest userAddRequest);
        Task<IdentityResult> Login(LoginRequest loginRequest); // Novbeti ders davam elemek ve JWT
        Task<UserDto> GetUserForUpdateById(int id);
        Task<IdentityResult> EditUserAsync(UserUpdateRequest userUpdateRequest);
        List<UserTableResponse> GetAllUsers();
        Task<IdentityResult> DeactivateUser(int id);
        Task<IdentityResult> ChangePasswordAsync(UserChangePasswordRequest userChangePasswordRequest);
        Task<IdentityResult> ResetPasswordAsync(UserResetPasswordRequest userResetPasswordRequest);
        Task<IdentityResult> CreateRoleAsync(RoleAddRequest roleAddRequest);
        Task<IdentityResult> AddUserToRoleAsync(int UserId, int RoleId);
        Task<IdentityResult> AddUserToRolesAsync(int UserId,List<int> RoleId);
        Task<IdentityResult> RemoveUserFromRoleAsync(int UserId,int RoleId);
        Task<IdentityResult> RemoveUserFromRolesAsync(int UserId,List<int> RoleId);
        //Task<UserDto> UserRoles(int UserId);
        Task<IdentityResult> DeactivateRole(int id);
        //Task<List<RoleTableResponse>> GetAllRolesAsync();
        List<RoleTableResponse> GetAllRoles();
    }
}
