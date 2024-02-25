using HotelAPI.Application.Services.Abstract;
using HotelAPI.Application.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.AdminModule.UserStatistics
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Authorize(Roles = AllowedRolesForController.Admin)]
    public class UserStatisticsController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IUserLoginHistoryService _userLoginHistoryService;


        public UserStatisticsController(IAccountService accountService, IUserLoginHistoryService userLoginHistoryService)
        {
            _accountService = accountService;
            _userLoginHistoryService = userLoginHistoryService;
        }

        [HttpGet("GetOnlineUsersCount")]
        public async Task<IActionResult> GetOnlineUsersCount()
        {
            var users = await _accountService.GetAllUsersAsync();
            var data = users.Where(u => u.NetworkStatus == NetworkStatus.Online).Count();
            return Ok(data);
        }

        [HttpGet("GetOfflineUsersCount")]
        public async Task<IActionResult> GetOfflineUsersCount()
        {
            var users = await _accountService.GetAllUsersAsync();
            var data = users.Where(u => u.NetworkStatus == NetworkStatus.Offline).Count();
            return Ok(data);
        }


        [HttpGet("GetUserLoginHistory")]
        public async Task<IActionResult> GetUserLoginHistory()
        {
            var data = await _userLoginHistoryService.GetAllAsync();
            return Ok(data);
        }
    }
}
