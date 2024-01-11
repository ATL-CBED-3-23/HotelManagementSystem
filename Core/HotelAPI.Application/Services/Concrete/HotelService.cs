using AutoMapper;
using HotelAPI.Application.DTOs.Hotels;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;

namespace HotelAPI.Application.Services.Concrete
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IMapper _mapper;

        public HotelService(IHotelRepository hotelRepository, IMapper mapper)
        {
            _mapper = mapper;
            _hotelRepository = hotelRepository;
        }

        public async Task AddAsync(HotelAddRequest hotelAddRequest)
        {
            var map = _mapper.Map<Hotel>(hotelAddRequest);

            await _hotelRepository.CreateAsync(map);
        }

        public async Task DeleteByIdAsync(int id)
        {
            Hotel hotel = await _hotelRepository.FindByIdAsync(id);
            await _hotelRepository.DeActivate(hotel);
        }

        public async Task EditAsync(HotelUpdateRequest hotelUpdateRequest)
        {
            var map = _mapper.Map<Hotel>(hotelUpdateRequest);
            await _hotelRepository.UpdateAsync(map);
        }

        public async Task<HotelUpdateRequest> GetForUpdateById(int id)
        {
            Hotel hotel = await _hotelRepository.FindByIdAsync(id);
            HotelUpdateRequest hotelUpdateRequest= _mapper.Map<HotelUpdateRequest>(hotel);

            return hotelUpdateRequest;
        }

        public async Task<List<HotelTableResponse>> GetTable()
        {
            var hotels= _hotelRepository.FindAllAsync();
            return _mapper.Map<List<HotelTableResponse>>(hotels);
        }
    }
}
