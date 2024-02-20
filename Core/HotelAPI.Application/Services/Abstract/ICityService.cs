using HotelAPI.Application.DTOs.Cities;

namespace HotelAPI.Application.Services.Abstract
{
    public interface ICityService
    {
        Task AddAsync(CityAddRequest cityAddRequest);
        Task EditAsync(CityUpdateRequest cityUpdateRequest);
        Task<CityTableResponse> GetByIdAsync(int id);
        Task<List<CityTableResponse>> GetTableAsync();
        Task DeleteByIdAsync(int id);

    }

}
