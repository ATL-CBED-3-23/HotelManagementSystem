using HotelAPI.Application.DTOs.HotelUserRoles;
using HotelAPI.Application.DTOs.HotelUsers;
using HotelAPI.Application.Services.Abstract;
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
            await _accountService.DeactivateUser(id);
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

        [HttpGet("GetAllRoles")]
        public IActionResult GetAllRoles()
        {
            var result =  _accountService.GetAllRoles();
            return Ok(result);
        }
    }
}
