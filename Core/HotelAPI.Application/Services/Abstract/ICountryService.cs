using HotelAPI.Application.DTOs.Countries;

namespace HotelAPI.Application.Services.Abstract
{
    public interface ICountryService
    {
        Task AddAsync(CountryAddRequest countryAddRequest);
        Task EditAsync(CountryUpdateRequest countryUpdateRequest);
        Task <CountryTableResponse> GetByIdAsync(int id);
        Task<List<CountryTableResponse>> GetTableAsync();
        Task DeleteByIdAsync(int id);
    }
}
