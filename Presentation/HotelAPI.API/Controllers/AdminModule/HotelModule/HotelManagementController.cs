using HotelAPI.Application.DTOs.Hotels;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Application.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.AdminModule.HotelModule
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Authorize(Roles = AllowedRolesForController.Admin)]

    public class HotelManagementController : ControllerBase
    {
        private readonly IHotelService _hotelService;
        public HotelManagementController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(HotelAddRequest hotelAddRequest)
        {
            await _hotelService.AddAsync(hotelAddRequest);
            return Ok();
        }

        [HttpGet("GetTable")]
        public async Task<IActionResult> GetTable()
        {
            var list = await _hotelService.GetTableAsync();
            return Ok(list);
        }

        [HttpGet("GetForEdit/{id}")]
        public async Task<IActionResult> GetForEdit(int id)
        {
            var item = await _hotelService.GetForEditByIdAsync(id);
            return Ok(item);
        }

        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(HotelUpdateRequest hotelUpdateRequest)
        {
            await _hotelService.EditAsync(hotelUpdateRequest);
            return Ok();
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _hotelService.DeleteByIdAsync(id);
            return Ok();
        }
    }
}
