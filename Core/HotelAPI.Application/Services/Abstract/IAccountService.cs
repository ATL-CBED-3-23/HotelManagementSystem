using HotelAPI.Application.DTOs.HotelUserRoles;
using HotelAPI.Application.DTOs.HotelUsers;
using Microsoft.AspNetCore.Identity;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IAccountService
    {
        Task<IdentityResult> RegisterUserAsync(UserAddRequest userAddRequest);
        Task<LoginedUserResponse> LoginAsync(LoginRequest loginRequest); 
        Task<UserToUpdateResponse> GetUserByIdAsync(int id);
        Task<IdentityResult> EditUserAsync(UserUpdateRequest userUpdateRequest);
        Task<List<UserTableResponse>> GetAllUsersAsync();
        Task<IdentityResult> DeActivateUserAsync(int id);
        Task<IdentityResult> ChangePasswordAsync(UserChangePasswordRequest userChangePasswordRequest);
        Task<IdentityResult> ResetPasswordAsync(UserResetPasswordRequest userResetPasswordRequest);
        Task<IdentityResult> CreateRoleAsync(RoleAddRequest roleAddRequest);
        Task<IdentityResult> AddUserToRoleAsync(int userId, int roleId);
        Task<IdentityResult> AddUserToRolesAsync(int userId, List<int> roleIds);
        Task<IdentityResult> RemoveUserFromRoleAsync(int userId, int roleIds);
        Task<IdentityResult> RemoveUserFromRolesAsync(int userId, List<int> roleIds);
        Task<IdentityResult> DeActivateRoleAsync(int id);
        List<RoleTableResponse> GetAllRolesAsync();


        Task<IdentityResult> SelfRegisterUserAsync(UserRegisterRequest userRegisterRequest);
        Task<IdentityResult> EditUserProfileAsync(UserProfileUpdateRequest userProfileUpdateRequest);
        Task<UserProfileToUpdateResponse> GetUserProfileByIdAsync(int id);
        Task<IdentityResult> RemoveAccountAsync();
    }
}
