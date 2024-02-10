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
            await _cityRepository.DeActivate(city);
        }

        public async Task EditAsync(CityUpdateRequest cityUpdateRequest)
        {
            var map = _mapper.Map<City>(cityUpdateRequest);
            await _cityRepository.UpdateAsync(map);
        }

        public async Task<CityUpdateRequest> GetForUpdateById(int id)
        {
            City city = await _cityRepository.FindByIdAsync(id);
            CityUpdateRequest cityUpdateRequest = _mapper.Map<CityUpdateRequest>(city);
            return cityUpdateRequest;
        }

        public async Task<List<CityTableResponse>> GetTable()
        {
           
            List<City> cities = await _cityRepository.FindAllAsync();
            List<Hotel> hotels = await _hotelRepository.FindAllAsync();
            List<Country> countries = await _countryRepository.FindAllAsync();

            var result = from country in countries
                         join city in cities on country.Id equals city.CountryId
                         join hotel in hotels on city.Id equals hotel.CityId
                         select
                                 new CityTableResponse
                                 {
                                     Id = city.Id,
                                     Name = city.Name,
                                     PostalCode = city.PostalCode,
                                     Country = country.Name,
                                     HotelTable = hotels
                         .Select(hotel => new HotelTableResponse
                         {
                             Id= hotel.Id,
                             Name = hotel.Name,
                             Address = hotel.Address,
                             PhoneNumber = hotel.PhoneNumber,
                             Email = hotel.Email,
                             Grade = hotel.Grade,
                         }).ToList()
                                 };
            return result.ToList();
        }
    }
}
