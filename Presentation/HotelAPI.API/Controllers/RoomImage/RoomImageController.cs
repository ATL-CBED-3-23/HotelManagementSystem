using HotelAPI.Application.DTOs.RoomImages;
using HotelAPI.Application.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.RoomImage
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


        [HttpPost("UploadImage")]
        public async Task<ActionResult> UploadImage(RoomImageAddRequest roomImageAddRequest)
        {

            //_logger.LogInformation(file.FileName);// we can put rest of upload logic here.
            await _roomImageService.AddAsync(roomImageAddRequest);
            return Ok();
        }
    }
}
