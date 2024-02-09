using HotelAPI.Application.DTOs.HotelImages;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IHotelImageService
    {
        Task AddAsync(HotelImageAddRequest hotelImageAddRequest);
    }

}
