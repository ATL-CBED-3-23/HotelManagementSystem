using HotelAPI.Application.DTOs.Rooms;
using HotelAPI.Application.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RoomAPI.API.Controllers.Room
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(RoomAddRequest roomAddRequest)
        {
            await _roomService.AddAsync(roomAddRequest);
            return Ok();
        }

        [HttpGet("GetTable")]
        public async Task<IActionResult> GetTable()
        {
            var list = await _roomService.GetTable();
            return Ok(list);
        }

        [HttpGet("GetForEdit/{id}")]
        public async Task<IActionResult> GetForEdit(int id)
        {
            var item = await _roomService.GetForUpdateById(id);
            return Ok(item);
        }

        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(RoomUpdateRequest roomUpdateRequest)
        {
            await _roomService.EditAsync(roomUpdateRequest);
            return Ok();
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _roomService.DeleteByIdAsync(id);
            return Ok();
        }
    }
}
