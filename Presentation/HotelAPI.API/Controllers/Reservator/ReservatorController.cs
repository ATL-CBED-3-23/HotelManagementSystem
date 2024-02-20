using HotelAPI.Application.DTOs.Reservators;
using HotelAPI.Application.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReservatorAPI.API.Controllers.Reservator
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class ReservatorController : ControllerBase
    {
        private readonly IReservatorService _reservatorService;
        public ReservatorController(IReservatorService reservatorService)
        {
            _reservatorService = reservatorService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(ReservatorAddRequest reservatorAddRequest)
        {
            await _reservatorService.AddAsync(reservatorAddRequest);
            return Ok();
        }

        [HttpGet("GetTable")]
        public async Task<IActionResult> GetTable()
        {
            var list = await _reservatorService.GetTableAsync();
            return Ok(list);
        }

        [HttpGet("GetForEdit/{id}")]
        public async Task<IActionResult> GetForEdit(int id)
        {
            var item = await _reservatorService.GetByIdAsync(id);
            return Ok(item);
        }

        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(ReservatorUpdateRequest reservatorUpdateRequest)
        {
            await _reservatorService.EditAsync(reservatorUpdateRequest);
            return Ok();
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _reservatorService.DeleteByIdAsync(id);
            return Ok();
        }
    }
}
