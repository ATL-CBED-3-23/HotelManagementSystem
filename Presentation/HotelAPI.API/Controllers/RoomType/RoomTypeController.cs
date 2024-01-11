using HotelAPI.Application.DTOs.RoomTypes;
using HotelAPI.Application.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace RoomTypeAPI.API.Controllers.RoomType
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypeService _roomTypeService;
        public RoomTypeController(IRoomTypeService roomTypeService)
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
            var list = await _roomTypeService.GetTable();
            return Ok(list);
        }

        [HttpGet("GetForEdit/{id}")]
        public async Task<IActionResult> GetForEdit(int id)
        {
            var item = await _roomTypeService.GetForUpdateById(id);
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
