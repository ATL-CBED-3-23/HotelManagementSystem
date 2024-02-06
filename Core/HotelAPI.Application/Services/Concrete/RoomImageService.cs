using AutoMapper;
using HotelAPI.Application.DTOs.Images;
using HotelAPI.Application.DTOs.Rooms;
using HotelAPI.Application.Helpers;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using Microsoft.AspNetCore.Http;

namespace HotelAPI.Application.Services.Concrete
{
    public class RoomImageService : IRoomImageService
    {
        private readonly IRoomImageRepository _roomImageRepository;
        private readonly IMapper _mapper;

        public RoomImageService(IRoomImageRepository roomImageRepository)
        {
            _roomImageRepository = roomImageRepository;
        }

        public async Task AddAsync(RoomImageAddRequest roomImageAddRequest, IFormFile file)
        {
            RoomImage image = _mapper.Map<RoomImage>(roomImageAddRequest);
            image.ImagePath = ImageHelper.Upload(file);

            await _roomImageRepository.CreateAsync(image);
        }
    }
}
