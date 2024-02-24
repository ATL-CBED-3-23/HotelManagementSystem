using HotelAPI.Application.DTOs.HotelRating;
using HotelAPI.Application.DTOs.Hotels;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Application.Utilities.Constants;
using HotelAPI.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.Hotel
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Authorize(Roles = AllowedRolesForController.ADMIN_and_STAFF_and_USER)]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;
        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet("SearchHotelsByCity")]
        public async Task<IActionResult> SearchHotelsByCity(int cityId)
        {
            var data = await _hotelService.GetHotelsByCityAsync(cityId);
            return Ok(data);
        }

        [HttpGet("SearchHotelsByRoomCount")]
        public async Task<IActionResult> SearchHotelsByRoomCount(int roomCount)
        {
            var data = await _hotelService.GetHotelsByRoomCountAsync(roomCount);
            return Ok(data);
        }

        [HttpPost("AddRating")]
        public async Task<IActionResult> AddRating(HotelRatingAddRequest req)
        {
            await _hotelService.AddRatingAsync(req);
            return Ok();
        }

        [HttpGet("GetHotelRating")]
        public async Task<IActionResult> GetHotelRating(int hotelId)
        {
            var result = await _hotelService.GetHotelRatingAsync(hotelId);
            return Ok(result);
        }
    }
}
