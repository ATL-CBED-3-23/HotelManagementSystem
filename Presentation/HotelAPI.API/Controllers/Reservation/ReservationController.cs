using HotelAPI.Application.DTOs.Reservations;
using HotelAPI.Application.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReservationAPI.API.Controllers.Reservation
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = "Bearer")]
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
            await _reservationService.AddAsync(reservationAddRequest);
            return Ok();
        }

        [HttpGet("GetTable")]
        public async Task<IActionResult> GetTable()
        {
            var list = await _reservationService.GetTable();
            return Ok(list);
        }

        [HttpGet("GetForEdit/{id}")]
        public async Task<IActionResult> GetForEdit(int id)
        {
            var item = await _reservationService.GetForUpdateById(id);
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

        [HttpGet("GetReseravtionsByUser")]
        public async Task<IActionResult> GetReseravtionsByUser(int userId)
        {
            var data = await _reservationService.GetReservationsByUser(userId);
            return Ok(data);
        }
    }
}
