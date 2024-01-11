﻿using HotelAPI.Application.DTOs.Countries;
using HotelAPI.Application.DTOs.Country;
using HotelAPI.Application.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace HotelAPI.API.Controllers.Country
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(CountryAddRequest createCountryDto)
        {
            await _countryService.AddAsync(createCountryDto);
            return Ok();
        }

        [HttpGet("GetTable")]
        public async Task<IActionResult> GetTable()
        {
          var list = await _countryService.GetTable();
            return Ok(list);    
        }

        [HttpGet("GetForEdit/{id}")]
        public async Task<IActionResult> GetForEdit(int id)
        {
            var item = await _countryService.GetForUpdateById(id);
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
