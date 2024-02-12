using AutoMapper;
using HotelAPI.Application.DTOs.HotelImages;
using HotelAPI.Application.DTOs.Hotels;
using HotelAPI.Application.DTOs.RoomImages;
using HotelAPI.Application.DTOs.Rooms;
using HotelAPI.Application.Helpers;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using System.Text;

namespace HotelAPI.Application.Services.Concrete
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;
        private readonly IRoomImageRepository _roomImageRepository;
        private readonly IRoomTypeRepository _roomTypeRepository;

        public RoomService(IRoomRepository roomRepository, IMapper mapper, IRoomImageRepository roomImageRepository, IRoomTypeRepository roomTypeRepository)
        {
            _mapper = mapper;
            _roomRepository = roomRepository;
            _roomImageRepository = roomImageRepository;
            _roomTypeRepository = roomTypeRepository;
        }

        public async Task AddAsync(RoomAddRequest roomAddRequest)
        {
            foreach (var image in roomAddRequest.RoomImages)
            {
                byte[] bytes = Convert.FromBase64String(image.FileBase64);
                image.FileName = FileHelper.SavePhotoToFtp(bytes, image.FileName);
            }
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

        public async Task<RoomTableResponse> GetForUpdateById(int id)
        {
            var rooms = await _roomRepository.FindAllAsync();
            var images = await _roomImageRepository.FindAllAsync();
            var roomTypes = await _roomTypeRepository.FindAllAsync();
            var result = from room in rooms
                         join image in images on room.Id equals image.RoomId
                         join type in roomTypes on room.RoomTypeId equals type.Id
                         where room.Id == id
                         select new RoomTableResponse()
                         {
                             Id = room.Id,
                             Floor = room.Floor,
                             Number = room.Number,
                             Phone = room.Phone,
                             Price = room.Price,
                             RoomState = room.RoomState,
                             RoomType = type.Name,
                             RoomImages = _mapper.Map<List<RoomImageTableResponse>>(room.RoomImages)
                         };
            foreach (var image in result.FirstOrDefault().RoomImages)
            {
                byte[] bytes = FileHelper.GetPhoto(image.FileName);
                image.FileBase64 = Encoding.UTF8.GetString(bytes);
            }

            return result.FirstOrDefault();
        }

        public async Task<List<RoomTableResponse>> GetTable()
        {
            var rooms = await _roomRepository.FindAllAsync();
            var images = await _roomImageRepository.FindAllAsync();
            var roomTypes = await _roomTypeRepository.FindAllAsync();
            var result = from room in rooms
                         join image in images on room.Id equals image.RoomId
                         join type in roomTypes on room.RoomTypeId equals type.Id
                         select new RoomTableResponse()
                         {
                             Id = room.Id,
                             Floor = room.Floor,
                             Number = room.Number,
                             Phone = room.Phone,
                             Price = room.Price,
                             RoomState = room.RoomState,
                             RoomType = type.Name,
                             RoomImages = _mapper.Map<List<RoomImageTableResponse>>(room.RoomImages)
                         };

            foreach (var room in result)
            {
                foreach (var image in room.RoomImages)
                {
                    byte[] bytes = FileHelper.GetPhoto(image.FileName);
                    image.FileBase64 = Encoding.UTF8.GetString(bytes);
                }
            }

            return result.ToList();
        }
    }
}
