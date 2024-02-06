﻿using HotelAPI.Application.DTOs.HotelUserRoles;
using HotelAPI.Application.DTOs.HotelUsers;
using Microsoft.AspNetCore.Identity;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IAccountService
    {
        Task<IdentityResult> RegisterUserAsync(UserAddRequest userAddRequest);
        Task<LoginedUserResponse> Login(LoginRequest loginRequest); // Novbeti ders davam elemek ve JWT
        Task<UserToUpdateResponse> GetUserForUpdateById(int id);
        Task<IdentityResult> EditUserAsync(UserUpdateRequest userUpdateRequest);
        List<UserTableResponse> GetAllUsers();
        Task<IdentityResult> DeActivateUser(int id);
        Task<IdentityResult> ChangePasswordAsync(UserChangePasswordRequest userChangePasswordRequest);
        Task<IdentityResult> ResetPasswordAsync(UserResetPasswordRequest userResetPasswordRequest);
        Task<IdentityResult> CreateRoleAsync(RoleAddRequest roleAddRequest);
        Task<IdentityResult> AddUserToRoleAsync(int userId, int roleId);
        Task<IdentityResult> AddUserToRolesAsync(int userId, List<int> roleIds);
        Task<IdentityResult> RemoveUserFromRoleAsync(int userId, int roleIds);
        Task<IdentityResult> RemoveUserFromRolesAsync(int userId, List<int> roleIds);
        Task<IdentityResult> DeActivateRole(int id);
        //Task<List<RoleTableResponse>> GetAllRolesAsync();
        List<RoleTableResponse> GetAllRoles();


        Task<IdentityResult> RegisterGuestUserAsync(GuestUserAddRequest guestUserAddRequest);
        Task<IdentityResult> EditGuestUserAsync(GuestUserUpdateRequest guestUserUpdateRequest);
        Task<GuestUserToUpdateResponse> GetGuestUserForUpdateById(int id);
    }
}
