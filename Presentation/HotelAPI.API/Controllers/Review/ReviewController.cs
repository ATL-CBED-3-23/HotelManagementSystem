using HotelAPI.Application.DTOs.Reviews;
using HotelAPI.Application.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ReviewAPI.API.Controllers.Review
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;
        public ReviewController(IReviewService reviewService)
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
            var list = await _reviewService.GetTable();
            return Ok(list);
        }

        [HttpGet("GetForEdit/{id}")]
        public async Task<IActionResult> GetForEdit(int id)
        {
            var item = await _reviewService.GetForUpdateById(id);
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
