﻿using HotelAPI.Application.DTOs.HotelRatings;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Application.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.Hotel
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Authorize(Roles = AllowedRolesForController.Admin_and_Staff_and_User)]
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
        public async Task<IActionResult> AddRating(HotelRatingAddRequest hotelRatingAddRequest)
        {
            await _hotelService.AddRatingAsync(hotelRatingAddRequest);
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
