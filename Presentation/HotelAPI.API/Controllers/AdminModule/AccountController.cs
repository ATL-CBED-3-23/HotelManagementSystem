using HotelAPI.Application.DTOs.HotelUserRoles;
using HotelAPI.Application.DTOs.HotelUsers;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Application.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.AdminModule
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Authorize(Roles = AllowedRolesForController.ADMIN)]

    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("RegisterUser")]
        public async Task<IActionResult> RegisterUser(UserAddRequest userAddRequest)
        {
            await _accountService.RegisterUserAsync(userAddRequest);
            return Ok();
        }

        [HttpGet("GetAllUsersAsync")]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await _accountService.GetAllUsersAsync();
            return Ok(result);
        }

        [HttpGet("GetUserById")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var result = await _accountService.GetUserByIdAsync(id);
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
            await _accountService.DeActivateUserAsync(id);
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
            await _accountService.DeActivateRoleAsync(id);
            return Ok();
        }

        [HttpGet("GetAllRoles")]
        public IActionResult GetAllRoles()
        {
            var result = _accountService.GetAllRolesAsync();
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

        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword(UserResetPasswordRequest userResetPasswordRequest)
        {
            await _accountService.ResetPasswordAsync(userResetPasswordRequest);
            return Ok();
        }

      

       
    }
}
