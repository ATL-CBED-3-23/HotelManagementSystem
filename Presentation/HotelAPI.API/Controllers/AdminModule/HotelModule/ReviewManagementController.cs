using HotelAPI.Application.DTOs.Reviews;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Application.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.AdminModule.HotelModule
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Authorize(Roles = AllowedRolesForController.Admin_and_Staff)]

    public class ReviewManagementController : ControllerBase
    {
        private readonly IReviewService _reviewService;
        public ReviewManagementController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(ReviewAddRequest reviewAddRequest)
        {
            await _reviewService.AddAsync(reviewAddRequest);
            return Ok();
        }

        [HttpGet("GetTable")]
        public async Task<IActionResult> GetTable()
        {
            var list = await _reviewService.GetTableAsync();
            return Ok(list);
        }

        [HttpGet("GetForEdit/{id}")]
        public async Task<IActionResult> GetForEdit(int id)
        {
            var item = await _reviewService.GetForEditByIdAsync(id);
            return Ok(item);
        }

        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(ReviewUpdateRequest reviewUpdateRequest)
        {
            await _reviewService.EditAsync(reviewUpdateRequest);
            return Ok();
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _reviewService.DeleteByIdAsync(id);
            return Ok();
        }
    }
}
