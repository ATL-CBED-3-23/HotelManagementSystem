using AutoMapper;
using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.DTOs.Countries;
using HotelAPI.Application.DTOs.Country;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;

namespace HotelAPI.Application.Services.Concrete
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public CountryService(ICountryRepository countryRepository, ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _countryRepository = countryRepository;
            _mapper = mapper;
        }
        public async Task AddAsync(CountryAddRequest countryAddRequest)
        {
            var map = _mapper.Map<Country>(countryAddRequest);
            await _countryRepository.CreateAsync(map);

        }
        public async Task<CountryUpdateRequest> GetForUpdateById(int id)
        {
            Country country = await _countryRepository.FindByIdAsync(id);
            return _mapper.Map<CountryUpdateRequest>(country);



        }
        public async Task EditAsync(CountryUpdateRequest countryUpdateRequest)
        {
            var map = _mapper.Map<Country>(countryUpdateRequest);
            await _countryRepository.UpdateAsync(map);

        }
        public async Task<List<CountryTableResponse>> GetTable()
        {
            List<Country> countries = await _countryRepository.FindAllAsync();
            List<City> cities = await _cityRepository.FindAllAsync();

            return countries.Select(country => new CountryTableResponse
            {
                Id = country.Id,
                Name = country.Name,
                Cities = cities
                    .Where(city => city.CountryId == country.Id)
                    .Select(city => new CityTableResponse
                    {
                        Id = city.Id,
                        Name = city.Name,
                        PostalCode = city.PostalCode
                    })
                    .ToList()
            }).ToList();

        }
        public async Task DeleteByIdAsync(int id)
        {
            Country country = await _countryRepository.FindByIdAsync(id);
            await _countryRepository.DeActivate(country);
        }
    }
}