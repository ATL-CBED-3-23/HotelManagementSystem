using HotelAPI.Application.DTOs.HotelUserRoles;
using HotelAPI.Application.DTOs.HotelUsers;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Application.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.HotelUser
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Authorize(Roles = AllowedRolesForController.ADMIN_and_STAFF_and_USER)]


    public class UserController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public UserController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            LoginedUserResponse loginedUser = await _accountService.LoginAsync(loginRequest);
            return Ok(loginedUser);
        }

        [AllowAnonymous]
        [HttpPost("SelfRegistration")]
        public async Task<IActionResult> SelfRegistration(GuestUserAddRequest guestUserAddRequest)
        {
            await _accountService.RegisterGuestUserAsync(guestUserAddRequest);
            return Ok();
        }

        [HttpPost("ChangePassword")]
        public async Task<IActionResult> ChangePassword(UserChangePasswordRequest userChangePasswordRequest)
        {
            await _accountService.ChangePasswordAsync(userChangePasswordRequest);
            return Ok();
        }      

        [HttpGet("GetProfile")]
        public async Task<IActionResult> GetUserProfile(int id)
        {
            var result = await _accountService.GetGuestUserByIdAsync(id);
            return Ok(result);
        }

        [HttpPost("EditProfile")]
        public async Task<IActionResult> EditProfile(GuestUserUpdateRequest guestUserUpdateRequest)
        {
            await _accountService.EditGuestUserAsync(guestUserUpdateRequest);
            return Ok();
        }

        [HttpPost("RemoveAccount")]
        public async Task<IActionResult> RemoveAccount()
        {
            await _accountService.RemoveAccountAsync();
            return Ok();
        }

    }
}

/*
 --todo--
 guest adli ne varsa deyish

 
 
 */