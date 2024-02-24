using HotelAPI.Application.DTOs.Countries;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Application.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.AdminModule.HotelModule
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = AllowedRolesForController.ADMIN)]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class CountryManagementController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryManagementController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(CountryAddRequest countryAddRequest)
        {
            await _countryService.AddAsync(countryAddRequest);
            return Ok();
        }

        [HttpGet("GetTable")]
        public async Task<IActionResult> GetTable()
        {
            var list = await _countryService.GetTableAsync();
            return Ok(list);
        }

        [HttpGet("GetForEdit/{id}")]
        public async Task<IActionResult> GetForEdit(int id)
        {
            var item = await _countryService.GetByIdAsync(id);
            return Ok(item);
        }

        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(CountryUpdateRequest countryUpdateRequest)
        {
            await _countryService.EditAsync(countryUpdateRequest);
            return Ok();
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _countryService.DeleteByIdAsync(id);
            return Ok();
        }
    }
}
