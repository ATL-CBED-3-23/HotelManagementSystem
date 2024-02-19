using HotelAPI.Application.DTOs.Countries;

namespace HotelAPI.Application.Services.Abstract
{
    public interface ICountryService
    {
        Task AddAsync(CountryAddRequest countryAddRequest);
        Task EditAsync(CountryUpdateRequest countryUpdateRequest);
        Task <CountryTableResponse> GetById(int id);
        Task<List<CountryTableResponse>> GetTable();
        Task DeleteByIdAsync(int id);
    }
}
