using AutoMapper;
using HotelAPI.Application.DTOs.RoomTypes;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;

namespace HotelAPI.Application.Services.Concrete
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomTypeRepository _roomTypeRepository;
        private readonly IMapper _mapper;

        public RoomTypeService(IRoomTypeRepository roomTypeRepository, IMapper mapper)
        {
            _mapper = mapper;
            _roomTypeRepository = roomTypeRepository;
        }

        public async Task AddAsync(RoomTypeAddRequest roomTypeAddRequest)
        {
            var map = _mapper.Map<RoomType>(roomTypeAddRequest);

            await _roomTypeRepository.CreateAsync(map);
        }

        public async Task DeleteByIdAsync(int id)
        {
            RoomType roomType = await _roomTypeRepository.FindByIdAsync(id);
            await _roomTypeRepository.DeActivate(roomType);
        }

        public async Task EditAsync(RoomTypeUpdateRequest roomTypeUpdateRequest)
        {
            var map = _mapper.Map<RoomType>(roomTypeUpdateRequest);
            await _roomTypeRepository.UpdateAsync(map);
        }

        public async Task<RoomTypeUpdateRequest> GetForUpdateById(int id)
        {
            RoomType roomType = await _roomTypeRepository.FindByIdAsync(id);
            RoomTypeUpdateRequest roomTypeUpdateRequest = _mapper.Map<RoomTypeUpdateRequest>(roomType); ;
            return roomTypeUpdateRequest;
        }

        public async Task<List<RoomTypeTableResponse>> GetTable()
        {
            var roomTypes = _roomTypeRepository.FindAllAsync();
            return _mapper.Map<List<RoomTypeTableResponse>>(roomTypes);
        }
    }
}
