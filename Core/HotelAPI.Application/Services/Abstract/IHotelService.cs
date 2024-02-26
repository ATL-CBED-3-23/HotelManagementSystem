using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.DTOs.HotelRatings;
using HotelAPI.Application.DTOs.Hotels;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IHotelService
    {
        Task AddAsync(HotelAddRequest hotelAddRequest);
        Task EditAsync(HotelUpdateRequest hotelUpdateRequest);
        Task<HotelTableResponse> GetForEditByIdAsync(int id);
        Task<HotelTableView> GetByIdAsync(int id);
        Task<List<HotelTableResponse>> GetTableAsync();
        Task DeleteByIdAsync(int id);
        Task<List<HotelTableResponse>> GetHotelsByCityAsync(int cityId);
        Task<List<HotelTableResponse>> GetHotelsByRoomCountAsync(int roomCount);
        Task AddRatingAsync(HotelRatingAddRequest AddRequest);
        Task<double> GetHotelRatingAsync(int hotelId);
        Task<List<HotelTableResponseForDropdown>> GetTableForDropdownByConditionAsync(int cityId);
        Task<List<HotelTableResponseForDropdown>> GetTableForDropdownAsync();

    }
}
