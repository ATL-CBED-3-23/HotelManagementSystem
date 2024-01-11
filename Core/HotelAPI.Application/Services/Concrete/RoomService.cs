using AutoMapper;
using HotelAPI.Application.DTOs.Rooms;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;

namespace HotelAPI.Application.Services.Concrete
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;

        public RoomService(IRoomRepository roomRepository, IMapper mapper)
        {
            _mapper = mapper;
            _roomRepository = roomRepository;
        }

        public async Task AddAsync(RoomAddRequest roomAddRequest)
        {
            var map = _mapper.Map<Room>(roomAddRequest);

            await _roomRepository.CreateAsync(map);
        }

        public async Task DeleteByIdAsync(int id)
        {
            Room room = await _roomRepository.FindByIdAsync(id);
            await _roomRepository.DeActivate(room);
        }

        public async Task EditAsync(RoomUpdateRequest roomUpdateRequest)
        {
            var map = _mapper.Map<Room>(roomUpdateRequest);
            await _roomRepository.UpdateAsync(map);
        }

        public async Task<RoomUpdateRequest> GetForUpdateById(int id)
        {
            Room room = await _roomRepository.FindByIdAsync(id);
            RoomUpdateRequest roomUpdateRequest = _mapper.Map<RoomUpdateRequest>(room); ;
            return roomUpdateRequest;
        }

        public async Task<List<RoomTableResponse>> GetTable()
        {
            var rooms = _roomRepository.FindAllAsync();
            return _mapper.Map<List<RoomTableResponse>>(rooms);
        }
    }
}
