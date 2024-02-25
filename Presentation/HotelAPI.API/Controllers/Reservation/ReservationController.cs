using HotelAPI.Application.DTOs.Reservations;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Application.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReservationAPI.API.Controllers.Reservation
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Authorize(Roles = AllowedRolesForController.Admin_and_Staff_and_User)]

    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet("GetReservationsByUser")]
        public async Task<IActionResult> GetReservationsByUser()
        {
            var data = await _reservationService.GetReservationsByUserAsync();
            return Ok(data);
        }
    }
}
