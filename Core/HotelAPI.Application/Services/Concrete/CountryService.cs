using AutoMapper;
using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.DTOs.Countries;
using HotelAPI.Application.DTOs.Hotels;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using System.Net;
using System.Xml.Linq;

namespace HotelAPI.Application.Services.Concrete
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IHotelRepository _hotelRepository;
        private readonly IMapper _mapper;

        public CountryService(ICountryRepository countryRepository, ICityRepository cityRepository, IMapper mapper, IHotelRepository hotelRepository)
        {
            _cityRepository = cityRepository;
            _countryRepository = countryRepository;
            _mapper = mapper;
            _hotelRepository = hotelRepository;
        }
        public async Task AddAsync(CountryAddRequest countryAddRequest)
        {
            var map = _mapper.Map<Country>(countryAddRequest);
            await _countryRepository.CreateAsync(map);

        }
        public async Task<CountryTableResponse> GetForEditByIdAsync(int id)
        {
            List<Country> countries = await _countryRepository.FindAllActiveAsync();
            List<City> cities = await _cityRepository.FindAllActiveAsync();
            List<Hotel> hotels = await _hotelRepository.FindAllActiveAsync();
            var result = from country in countries
                         join city in cities on country.Id equals city.CountryId
                         join hotel in hotels on city.Id equals hotel.CityId
                         where country.Id == id
                         select new CountryTableResponse
                         {
                             Id = country.Id,
                             Name = country.Name,
                             Cities = country.Cities.Select(c => new CityTableResponse()
                             {
                                 Id = city.Id,
                                 Name = city.Name,
                                 HotelTable = city.Hotels.Select(h => new HotelTableResponse()
                                 {
                                     Name = hotel.Name,
                                     Address = hotel.Address,
                                     PhoneNumber = hotel.PhoneNumber,
                                     Email = hotel.Email,
                                     Grade = hotel.Grade,
                                 }).ToList(),

                             }).ToList()
                         };

            return result.FirstOrDefault();
        }
        public async Task<CountryTableView> GetByIdAsync(int id)
        {
            List<Country> countries = await _countryRepository.FindAllActiveAsync();
            List<City> cities = await _cityRepository.FindAllAsync();
            List<Hotel> hotels = await _hotelRepository.FindAllActiveAsync();
            var result = from country in countries
                         join city in cities on country.Id equals city.CountryId
                         join hotel in hotels on city.Id equals hotel.CityId
                         where country.Id == id
                         select new CountryTableView
                         {
                             Id = country.Id,
                             Name = country.Name,
                             Cities = country.Cities.Select(c => new CityTableResponse()
                             {
                                 Id = city.Id,
                                 Name = city.Name,
                                 HotelTable = city.Hotels.Select(h => new HotelTableResponse()
                                 {
                                     Name = hotel.Name,
                                     Address = hotel.Address,
                                     PhoneNumber = hotel.PhoneNumber,
                                     Email = hotel.Email,
                                     Grade = hotel.Grade,
                                 }).ToList(),

                             }).ToList()
                         };

            return result.FirstOrDefault();
        }
        public async Task EditAsync(CountryUpdateRequest countryUpdateRequest)
        {
            var map = _mapper.Map<Country>(countryUpdateRequest);
            await _countryRepository.UpdateAsync(map);

        }
        public async Task<List<CountryTableResponse>> GetTableAsync()
        {
            List<Country> countries = await _countryRepository.FindAllActiveAsync();
            List<City> cities = await _cityRepository.FindAllActiveAsync();
            List<Hotel> hotels = await _hotelRepository.FindAllActiveAsync();
            var result = from country in countries
                         join city in cities on country.Id equals city.CountryId
                         join hotel in hotels on city.Id equals hotel.CityId
                         select new CountryTableResponse
                         {
                             Id = country.Id,
                             Name = country.Name,
                             Cities = country.Cities.Select(c => new CityTableResponse()
                             {
                                 Id = city.Id,
                                 Name = city.Name,
                                 PostalCode = city.PostalCode,
                                 HotelTable = city.Hotels.Select(h => new HotelTableResponse()
                                 {
                                     Name = hotel.Name,
                                     Address = hotel.Address,
                                     PhoneNumber = hotel.PhoneNumber,
                                     Email = hotel.Email,
                                     Grade = hotel.Grade,
                                 }).ToList(),

                             }).ToList()
                         };

            return result.ToList();

        }
        public async Task DeleteByIdAsync(int id)
        {
            Country country = await _countryRepository.FindByIdAsync(id);
            await _countryRepository.DeActivateAsync(country);
        }
        public async Task<List<CountryTableResponseForDropdown>> GetTableForDropdownAsync()
        {
            List<Country> countries = await _countryRepository.FindAllActiveAsync();
            List<CountryTableResponseForDropdown> countryTableResponseForDropdown = _mapper.Map<List<CountryTableResponseForDropdown>>(countries);
            return countryTableResponseForDropdown;
        }
    }
}