using AutoMapper;
using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;

namespace HotelAPI.Application.Services.Concrete
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public CityService(ICityRepository cityRepository, IMapper mapper)
        {
            _mapper = mapper;
            _cityRepository = cityRepository;
        }
        public async Task AddAsync(CityAddRequest cityAddRequest)
        {
            var map = _mapper.Map<City>(cityAddRequest);

            await _cityRepository.CreateAsync(map);
        }
        
    }
}
