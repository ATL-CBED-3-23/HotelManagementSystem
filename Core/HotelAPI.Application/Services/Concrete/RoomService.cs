using AutoMapper;
using HotelAPI.Application.DTOs.HotelImages;
using HotelAPI.Application.DTOs.Hotels;
using HotelAPI.Application.DTOs.HotelUserRoles;
using HotelAPI.Application.DTOs.RoomImages;
using HotelAPI.Application.DTOs.Rooms;
using HotelAPI.Application.Helpers;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace HotelAPI.Application.Services.Concrete
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;
        private readonly IRoomImageRepository _roomImageRepository;
        private readonly IRoomTypeRepository _roomTypeRepository;
        private readonly IEquipmentRepository _equipmentRepository;

        public RoomService(IRoomRepository roomRepository, IMapper mapper, IRoomImageRepository roomImageRepository, 
            IRoomTypeRepository roomTypeRepository, IEquipmentRepository equipmentRepository)
        {
            _mapper = mapper;
            _roomRepository = roomRepository;
            _roomImageRepository = roomImageRepository;
            _roomTypeRepository = roomTypeRepository;
            _equipmentRepository = equipmentRepository;
        }

        public async Task AddAsync(RoomAddRequest roomAddRequest)
        {
            foreach (var image in roomAddRequest.RoomImages)
            {
                byte[] bytes = Convert.FromBase64String(image.FileBase64);
                image.FileName = FileHelper.SavePhotoToFtp(bytes, image.FileName);
            }
            var map = _mapper.Map<Room>(roomAddRequest);
            map.Equipments = new List<Equipment>();
            var t = await _equipmentRepository.FindAllActiveAsync();
            var x = t.Where(t => roomAddRequest.EquipmentIds.Contains(t.Id)).ToList() ;          
            map.Equipments.AddRange(x);
           
            await _roomRepository.CreateAsync(map);
        }

        public async Task DeleteByIdAsync(int id)
        {
            Room room = await _roomRepository.FindByIdAsync(id);
            await _roomRepository.DeActivateAsync(room);
        }

        public async Task EditAsync(RoomUpdateRequest roomUpdateRequest)
        {
            foreach (var image in roomUpdateRequest.RoomImages)
            {
                byte[] bytes = Convert.FromBase64String(image.FileBase64);
                image.FileName = FileHelper.SavePhotoToFtp(bytes, image.FileName);
            }

            var map = _mapper.Map<Room>(roomUpdateRequest);
            await _roomRepository.UpdateAsync(map);
        }

        public async Task<RoomTableResponse> GetByIdAsync(int id)
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
                             RoomImages = room.RoomImages.Select(x => new RoomImageTableResponse()
                             {
                                 Id = x.Id,
                                 FileName = x.FileName,
                                 FileBase64 = Convert.ToBase64String(FileHelper.GetPhoto(image.FileName))

                             }).ToList(),
                         };

            return result.FirstOrDefault();
        }

        public async Task<List<RoomTableResponse>> GetTableAsync()
        {

            var products =  _roomRepository.FindAllActiveAsync().Result
.SelectMany(p => p.Equipments).ToList() ;


            var rooms = await _roomRepository.FindAllActiveAsync();
            var images = await _roomImageRepository.FindAllActiveAsync();
            var roomTypes = await _roomTypeRepository.FindAllActiveAsync();
            var equipments = await _equipmentRepository.FindAllActiveAsync();
            var result = from room in rooms
                         join image in images on room.Id equals image.RoomId
                         join type in roomTypes on room.RoomTypeId equals type.Id
                         //join equipment in equipments on ro

                         select new RoomTableResponse()
                         {
                             Id = room.Id,
                             Floor = room.Floor,
                             Number = room.Number,
                             Phone = room.Phone,
                             Price = room.Price,
                             RoomState = room.RoomState,
                             RoomType = type.Name,
                            // Equipments=room.Equipments,
                             RoomImages = room.RoomImages.Select(x => new RoomImageTableResponse()
                             {
                                 Id = x.Id,
                                 FileName = x.FileName,
                                 FileBase64 = Convert.ToBase64String(FileHelper.GetPhoto(image.FileName))

                             }).ToList(),
                         };

            return result.ToList();
        }
    }
}
