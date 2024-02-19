using HotelAPI.Application.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.UserStatistics
{
    [Route("api/[controller]")]
    [ApiController]
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
