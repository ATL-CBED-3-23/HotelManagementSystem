﻿using HotelAPI.Application.DTOs.HotelUserRoles;
using HotelAPI.Application.DTOs.HotelUsers;
using HotelAPI.Application.Services.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.HotelUser
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public UserController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("RegisterUser")]
        public async Task<IActionResult> RegisterUser(UserAddRequest userAddRequest)
        {
            await _accountService.RegisterUserAsync(userAddRequest);
            return Ok();
        }

        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            var result = _accountService.GetAllUsers();
            return Ok(result);
        }

        [HttpGet("GetUserById")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var result = await _accountService.GetUserForUpdateById(id);
            return Ok(result);
        }

        [HttpPost("EditUser")]
        public async Task<IActionResult> EditUser(UserUpdateRequest userUpdateRequest)
        {
            await _accountService.EditUserAsync(userUpdateRequest);
            return Ok();
        }

        [HttpPost("DeleteUser")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _accountService.DeActivateUser(id);
            return Ok();
        }

        [HttpPost("ChangePassword")]
        public async Task<IActionResult> ChangePassword(UserChangePasswordRequest userChangePasswordRequest)
        {
            await _accountService.ChangePasswordAsync(userChangePasswordRequest);
            return Ok();
        }

        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword(UserResetPasswordRequest userResetPasswordRequest)
        {
            await _accountService.ResetPasswordAsync(userResetPasswordRequest);
            return Ok();
        }

        [HttpPost("CreateRole")]
        public async Task<IActionResult> CreateRole(RoleAddRequest roleAddRequest)
        {
            await _accountService.CreateRoleAsync(roleAddRequest);
            return Ok();
        }

        [HttpPost("DeleteRole")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            await _accountService.DeActivateRole(id);
            return Ok();
        }

        [HttpGet("GetAllRoles")]
        public IActionResult GetAllRoles()
        {
            var result = _accountService.GetAllRoles();
            return Ok(result);
        }

        [HttpPost("AddUserToRole")]
        public async Task<IActionResult> AddUserToRole(int userId, int roleId)
        {
            await _accountService.AddUserToRoleAsync(userId, roleId);
            return Ok();
        }

        [HttpPost("AddUserToRoles")]
        public async Task<IActionResult> AddUserToRoles(int userId, List<int> roleIds)
        {
            await _accountService.AddUserToRolesAsync(userId, roleIds);
            return Ok();
        }

        [HttpPost("RemoveUserFromRole")]
        public async Task<IActionResult> RemoveUserFromRole(int userId, int roleId)
        {
            await _accountService.RemoveUserFromRoleAsync(userId, roleId);
            return Ok();
        }

        [HttpPost("RemoveUserFromRoles")]
        public async Task<IActionResult> RemoveUserFromRoles(int userId, List<int> roleIds)
        {
            await _accountService.RemoveUserFromRolesAsync(userId, roleIds);
            return Ok();
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            await _accountService.Login(loginRequest);
            return Ok();
        }
    }
}
