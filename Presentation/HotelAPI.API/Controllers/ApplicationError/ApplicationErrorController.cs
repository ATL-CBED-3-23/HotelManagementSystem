using HotelAPI.Application.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.ApplicationError
{
    [Route("api/[controller]")]
    [ApiController]
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
            var applicationErrors = await _applicationErrorService.GetTable();
            return Ok(applicationErrors);
        }
    }
}
