using HotelAPI.Application.DTOs.Countries;
using HotelAPI.Application.DTOs.Country;
using HotelAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.Services.Abstract
{
    public interface ICountryService
    {
        Task AddAsync(CountryAddRequest createCountryDto);
        Task EditAsync(CountryUpdateRequest updateCountryDto);
        Task <CountryUpdateRequest> GetForUpdateById(int id);
        Task<List<CountryTableResponse>> GetTable();
        Task DeleteByIdAsync(int id);
    }
}
