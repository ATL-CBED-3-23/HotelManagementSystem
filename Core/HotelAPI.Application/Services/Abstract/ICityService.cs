﻿using HotelAPI.Application.DTOs.Cities;

namespace HotelAPI.Application.Services.Abstract
{
    public interface ICityService
    {
        Task AddAsync(CityAddRequest cityAddRequest);
        Task EditAsync(CityUpdateRequest cityUpdateRequest);
        Task<CityTableResponse> GetForEditByIdAsync(int id);
        Task<CityTableView> GetByIdAsync(int id);
        Task<List<CityTableResponse>> GetTableAsync();
        Task DeleteByIdAsync(int id);
        Task<List<CityTableResponseForDropdown>> GetTableForDropdownByConditionAsync(int countryId);
        Task<List<CityTableResponseForDropdown>> GetTableForDropdownAsync();
    }

}
