using HotelAPI.Application.DTOs.RoomTypes;
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

    public class RoomTypeManagementController : ControllerBase
    {
        private readonly IRoomTypeService _roomTypeService;
        public RoomTypeManagementController(IRoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(RoomTypeAddRequest roomTypeAddRequest)
        {
            await _roomTypeService.AddAsync(roomTypeAddRequest);
            return Ok();
        }

        [HttpGet("GetTable")]
        public async Task<IActionResult> GetTable()
        {
            var list = await _roomTypeService.GetTableAsync();
            return Ok(list);
        }

        [HttpGet("GetForEdit/{id}")]
        public async Task<IActionResult> GetForEdit(int id)
        {
            var item = await _roomTypeService.GetForEditByIdAsync(id);
            return Ok(item);
        }

        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(RoomTypeUpdateRequest roomTypeUpdateRequest)
        {
            await _roomTypeService.EditAsync(roomTypeUpdateRequest);
            return Ok();
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _roomTypeService.DeleteByIdAsync(id);
            return Ok();
        }
    }
}
