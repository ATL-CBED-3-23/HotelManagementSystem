using AutoMapper;
using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.DTOs.Countries;
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
        public async Task AddAsync(CountryAddRequest createCountryDto)
        {
            var map = _mapper.Map<Country>(createCountryDto);
            await _countryRepository.CreateAsync(map);

        }
        public async Task<CountryUpdateRequest> GetForUpdateById(int id)
        {
            Country country = await _countryRepository.FindByIdAsync(id);
            return _mapper.Map<CountryUpdateRequest>(country);



        }
        public async Task EditAsync(CountryUpdateRequest updateCountryDto)
        {
            var map = _mapper.Map<Country>(updateCountryDto);
            await _countryRepository.UpdateAsync(map);

        }
        public async Task<List<CountryTableResponse>> GetTable()
        {
            List<CountryTableResponse> countryTableResponses = new List<CountryTableResponse>();
            List<CityTableResponse> cityTableResponses = new List<CityTableResponse>();
            List<Country> coutries = await _countryRepository.FindAllAsync();
            List<City> city = await _cityRepository.FindAllAsync();

            foreach (var country in coutries)
            {
                CountryTableResponse countryTbl = new CountryTableResponse()
                {
                    Id = country.Id,
                    Name = country.Name,
                };
                CityTableResponse cityTableResponse = new CityTableResponse()
                {
                    Id = city.First(x => x.CountryId == country.Id).Id,
                    Name = city.First(x => x.CountryId == country.Id).Name,
                    PostalCode = city.First(x => x.CountryId == country.Id).PostalCode,
                };
                cityTableResponses.Add(cityTableResponse);

                countryTbl.Cities = cityTableResponses;
                countryTableResponses.Add(countryTbl);
            }
            return countryTableResponses;
        }
        public async Task DeleteByIdAsync(int id)
        {
            Country country = await _countryRepository.FindByIdAsync(id);
            await _countryRepository.DeActivate(country);
        }
    }
}