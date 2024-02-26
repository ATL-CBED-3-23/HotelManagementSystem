using AutoMapper;
using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.DTOs.Countries;
using HotelAPI.Application.DTOs.Hotels;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;

namespace HotelAPI.Application.Services.Concrete
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IHotelRepository _hotelRepository;
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public CityService(ICityRepository cityRepository, IMapper mapper, IHotelRepository hotelRepository, ICountryRepository countryRepository)
        {
            _mapper = mapper;
            _cityRepository = cityRepository;
            _hotelRepository = hotelRepository;
            _countryRepository = countryRepository;
        }
        public async Task AddAsync(CityAddRequest cityAddRequest)
        {
            var map = _mapper.Map<City>(cityAddRequest);

            await _cityRepository.CreateAsync(map);
        }
        public async Task DeleteByIdAsync(int id)
        {
            var city = await _cityRepository.FindByIdAsync(id);
            await _cityRepository.DeActivateAsync(city);
        }
        public async Task EditAsync(CityUpdateRequest cityUpdateRequest)
        {
            var map = _mapper.Map<City>(cityUpdateRequest);
            await _cityRepository.UpdateAsync(map);
        }
        public async Task<CityTableResponse> GetForEditByIdAsync(int id)
        {
            List<City> cities = await _cityRepository.FindAllActiveAsync();
            List<Hotel> hotels = await _hotelRepository.FindAllActiveAsync();
            var result = from city in cities
                         join hotel in hotels on city.Id equals hotel.CityId
                         where city.Id == id
                         select new CityTableResponse
                         {
                             Id = city.Id,
                             Name = city.Name,
                             PostalCode = city.PostalCode,
                             Country = _mapper.Map<CountryTableResponse>(city.Country),
                             HotelTable = city.Hotels.Select(h => new HotelTableResponse()
                             {
                                 Id = h.Id,
                                 Name = hotel.Name,
                                 Address = hotel.Address,
                                 PhoneNumber = hotel.PhoneNumber,
                                 Email = hotel.Email,
                                 Grade = hotel.Grade,
                             }).ToList(),
                         };

            return result.FirstOrDefault();
        }
        public async Task<CityTableView> GetByIdAsync(int id)
        {
            List<City> cities = await _cityRepository.FindAllActiveAsync();
            List<Hotel> hotels = await _hotelRepository.FindAllActiveAsync();
            var result = from city in cities
                         join hotel in hotels on city.Id equals hotel.CityId
                         where city.Id == id
                         select new CityTableView
                         {
                             Id = city.Id,
                             Name = city.Name,
                             Country = _mapper.Map<CountryTableResponse>(city.Country),
                             HotelTable = city.Hotels.Select(h => new HotelTableResponse()
                             {
                                 Id = h.Id,
                                 Name = hotel.Name,
                                 Address = hotel.Address,
                                 PhoneNumber = hotel.PhoneNumber,
                                 Email = hotel.Email,
                                 Grade = hotel.Grade,
                             }).ToList(),
                         };

            return result.FirstOrDefault();
        }
        public async Task<List<CityTableResponse>> GetTableAsync()
        {
            List<City> cities = await _cityRepository.FindAllActiveAsync();
            List<Hotel> hotels = await _hotelRepository.FindAllActiveAsync();
            var result = from city in cities
                         join hotel in hotels on city.Id equals hotel.CityId
                         select new CityTableResponse
                         {
                             Id = city.Id,
                             Name = city.Name,
                             PostalCode = city.PostalCode,
                             Country = _mapper.Map<CountryTableResponse>(city.Country),
                             HotelTable = city.Hotels.Select(h => new HotelTableResponse()
                             {
                                 Id = h.Id,
                                 Name = hotel.Name,
                                 Address = hotel.Address,
                                 PhoneNumber = hotel.PhoneNumber,
                                 Email = hotel.Email,
                                 Grade = hotel.Grade,
                             }).ToList(),
                         };

            return result.ToList();
        }
        public async Task<List<CityTableResponseForDropdown>> GetTableForDropdownByConditionAsync(int countryId)
        {
            List<City> cities = await _cityRepository.FindByConditionAsync(c => c.EntityStatus == EntityStatus.Active && c.CountryId == countryId);
            List<CityTableResponseForDropdown> cityTableResponseForDropdown = _mapper.Map<List<CityTableResponseForDropdown>>(cities);
            return cityTableResponseForDropdown;
        }
        public async Task<List<CityTableResponseForDropdown>> GetTableForDropdownAsync()
        {
            List<City> cities = await _cityRepository.FindAllActiveAsync();
            List<CityTableResponseForDropdown> cityTableResponseForDropdown = _mapper.Map<List<CityTableResponseForDropdown>>(cities);
            return cityTableResponseForDropdown;
        }

    }
}
