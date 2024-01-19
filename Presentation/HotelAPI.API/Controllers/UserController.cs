using HotelAPI.Application.DTOs.HotelUsers;
using HotelAPI.Application.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers
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
    }
}
