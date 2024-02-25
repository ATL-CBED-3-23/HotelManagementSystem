using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Application.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.AdminModule.HotelModule
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Authorize(Roles = AllowedRolesForController.Admin)]

    public class CityManagementController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityManagementController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(CityAddRequest cityAddRequest)
        {
            await _cityService.AddAsync(cityAddRequest);
            return Ok();
        }

        [HttpGet("GetTable")]
        public async Task<IActionResult> GetTable()
        {
            var list = await _cityService.GetTableAsync();
            return Ok(list);
        }

        [HttpGet("GetForEdit/{id}")]
        public async Task<IActionResult> GetForEdit(int id)
        {
            var item = await _cityService.GetByIdAsync(id);
            return Ok(item);
        }

        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(CityUpdateRequest cityUpdateRequest)
        {
            await _cityService.EditAsync(cityUpdateRequest);
            return Ok();
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _cityService.DeleteByIdAsync(id);
            return Ok();
        }
    }
}
