using HotelAPI.Application.DTOs.Countries;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Application.Services.Concrete;
using HotelAPI.Application.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.Country
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = "Bearer")]
    //[Authorize(Roles = AllowedRolesForController.ADMIN_and_STAFF_and_USER)]


    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _countryService.GetByIdAsync(id);
            return Ok(item);
        }

        [HttpGet("GetCountryTableForDropdown")]
        public async Task<IActionResult> GetCountryTableForDropdown()
        {
            var item = await _countryService.GetTableForDropdownAsync();
            return Ok(item);
        }

    }
}
