using HotelAPI.Application.Services.Abstract;
using HotelAPI.Application.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.AdminModule.ApplicationError
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Authorize(Roles = AllowedRolesForController.Admin)]
    public class ApplicationErrorController : ControllerBase
    {
        private readonly IApplicationErrorService _applicationErrorService;

        public ApplicationErrorController(IApplicationErrorService applicationErrorService)
        {
            _applicationErrorService = applicationErrorService;
        }

        [HttpGet("GetAllApplicationErrors")]
        public async Task<IActionResult> GetAllApplicationErrors()
        {
            var applicationErrors = await _applicationErrorService.GetTableAsync();
            return Ok(applicationErrors);
        }
    }
}
