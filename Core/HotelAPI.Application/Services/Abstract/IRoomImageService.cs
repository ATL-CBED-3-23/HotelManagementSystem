using HotelAPI.Application.DTOs.RoomImages;
using Microsoft.AspNetCore.Http;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IRoomImageService
    {
        Task AddAsync(RoomImageAddRequest roomImageAddRequest);

    }

}
