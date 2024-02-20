using HotelAPI.Application.DTOs.HotelRating;
using HotelAPI.Application.DTOs.Hotels;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.Hotel
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize(AuthenticationSchemes = "Bearer")]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;
        public HotelController(IHotelService hotelService)
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
            var item = await _hotelService.GetForUpdateByIdAsync(id);
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

        [HttpGet("SearchHotelsByCity")]
        public async Task<IActionResult> SearchHotelsByCity(int cityId)
        {
            var data= await _hotelService.GetHotelsByCityAsync(cityId);
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
        public async Task<IActionResult> GetHotelRating(int HotelId)
        { 
           var res= await _hotelService.GetHotelRatingAsync(HotelId);
            return Ok(res);
        }
    }
}
