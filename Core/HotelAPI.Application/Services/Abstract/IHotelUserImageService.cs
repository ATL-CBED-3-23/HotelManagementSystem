using HotelAPI.Application.DTOs.HotelUserImages;
using HotelAPI.Application.DTOs.RoomImages;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IHotelUserImageService
    {
        Task AddAsync(HotelUserImageAddRequest hotelUserImageAddRequest);

    }

}
