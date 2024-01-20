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

        [HttpPost("CreateRole")]
        public async Task<IActionResult> CreateRole(RoleAddRequest roleAddRequest)
        {
            await _accountService.CreateRoleAsync(roleAddRequest);
            return Ok();
        }

        [HttpGet("GetAllRoles")]
        public async Task<IActionResult> GetAllRoles()
        {
            var result = await _accountService.GetAllRolesAsync();
            return Ok(result);
        }
    }
}
