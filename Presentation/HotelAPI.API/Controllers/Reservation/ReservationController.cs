using HotelAPI.Application.DTOs.Reservations;
using HotelAPI.Application.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReservationAPI.API.Controllers.Reservation
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(ReservationAddRequest reservationAddRequest)
        {
            string message=await _reservationService.AddAsync(reservationAddRequest);
            return Ok(message);
        }

        [HttpGet("GetTable")]
        public async Task<IActionResult> GetTable()
        {
            var list = await _reservationService.GetTableAsync();
            return Ok(list);
        }

        [HttpGet("GetForEdit/{id}")]
        public async Task<IActionResult> GetForEdit(int id)
        {
            var item = await _reservationService.GetByIdAsync(id);
            return Ok(item);
        }

        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(ReservationUpdateRequest reservationUpdateRequest)
        {
            await _reservationService.EditAsync(reservationUpdateRequest);
            return Ok();
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _reservationService.DeleteByIdAsync(id);
            return Ok();
        }

        [HttpGet("GetReservationsByUser")]
        public async Task<IActionResult> GetReservationsByUser(int userId)
        {
            var data = await _reservationService.GetReservationsByUserAsync(userId);
            return Ok(data);
        }

        [HttpGet("GetReservationsByGuestUser")]
        public async Task<IActionResult> GetReservationsByGuestUser()
        {
            var data = await _reservationService.GetReservationsByGuestUserAsync();
            return Ok(data);
        }
    }
}
