using HotelAPI.Application.DTOs.Cities;

namespace HotelAPI.Application.Services.Abstract
{
    public interface ICityService
    {
        Task AddAsync(CityAddRequest cityAddRequest);
        Task EditAsync(CityUpdateRequest cityUpdateRequest);
        Task<CityTableResponse> GetById(int id);
        Task<List<CityTableResponse>> GetTable();
        Task DeleteByIdAsync(int id);

    }

}
