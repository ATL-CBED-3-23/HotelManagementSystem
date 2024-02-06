using HotelAPI.Application.DTOs.Images;
using HotelAPI.Application.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.Image
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomImageController : ControllerBase
    {
        private readonly IRoomImageService _roomImageService;

        public RoomImageController(IRoomImageService roomImageService)
        {
            _roomImageService = roomImageService;
        }

        //[HttpPost("upload")]
        //[Consumes("multipart/form-data")]
        //public async Task<IActionResult> Add(IFormFile file, RoomImageAddRequest roomImageAddRequest)
        //{
        //    await _roomImageService.AddAsync(roomImageAddRequest,file);
        //    return Ok();
        //}

        [HttpPost("UploadImage")]
        public async Task<ActionResult> UploadImage(RoomImageAddRequest roomImageAddRequest)
        {

            //_logger.LogInformation(file.FileName);// we can put rest of upload logic here.
            await _roomImageService.AddAsync(roomImageAddRequest);
            return Ok();
        }
    }
}
