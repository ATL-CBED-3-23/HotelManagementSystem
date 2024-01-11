using HotelAPI.Application.DTOs.Hotels;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IHotelService
    {
        Task AddAsync(HotelAddRequest hotelAddRequest);
        Task EditAsync(HotelUpdateRequest hotelUpdateRequest);
        Task<HotelUpdateRequest> GetForUpdateById(int id);
        Task<List<HotelTableResponse>> GetTable();
        Task DeleteByIdAsync(int id);
    }
}
