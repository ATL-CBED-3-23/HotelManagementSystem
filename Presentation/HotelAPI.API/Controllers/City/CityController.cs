using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Application.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.City
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Authorize(Roles = AllowedRolesForController.Admin)]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _cityService.GetByIdAsync(id);
            return Ok(item);
        }

        [HttpGet("GetCityTableForDropdownByCountryId/{countryId}")]
        public async Task<IActionResult> GetCityTableForDropdownByCountryId(int countryId)
        {
            var item = await _cityService.GetTableForDropdownByConditionAsync(countryId);
            return Ok(item);
        }

        [HttpGet("GetCityTableForDropdown")]
        public async Task<IActionResult> GetCityTableForDropdown()
        {
            var item = await _cityService.GetTableForDropdownAsync();
            return Ok(item);
        }



    }
}
