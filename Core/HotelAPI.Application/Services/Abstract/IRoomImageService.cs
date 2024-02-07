using HotelAPI.Application.DTOs.Images;
using Microsoft.AspNetCore.Http;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IRoomImageService
    {
        Task AddAsync(RoomImageAddRequest roomImageAddRequest);


    }

}
