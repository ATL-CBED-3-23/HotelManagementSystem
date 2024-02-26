using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.DTOs.Countries;

namespace HotelAPI.Application.Services.Abstract
{
    public interface ICountryService
    {
        Task AddAsync(CountryAddRequest countryAddRequest);
        Task EditAsync(CountryUpdateRequest countryUpdateRequest);
        Task<CountryTableResponse> GetForEditByIdAsync(int id);
        Task<CountryTableView> GetByIdAsync(int id);
        Task<List<CountryTableResponse>> GetTableAsync();
        Task<List<CountryTableResponseForDropdown>> GetTableForDropdownAsync();
        Task DeleteByIdAsync(int id);
    }
}
