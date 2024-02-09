using AutoMapper;
using HotelAPI.Application.DTOs.RoomImages;
using HotelAPI.Application.Helpers;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using Microsoft.Extensions.Options;

namespace HotelAPI.Application.Services.Concrete
{
    public class RoomImageService : IRoomImageService
    {
        private readonly IRoomImageRepository _roomImageRepository;
        private readonly IMapper _mapper;
        private readonly FileServerPath _fileServerPath;

        public RoomImageService(IRoomImageRepository roomImageRepository,IMapper mapper, IOptionsSnapshot<FileServerPath> filePath)
        {
            _roomImageRepository = roomImageRepository;
            _mapper = mapper;
            _fileServerPath = filePath.Value;
        }

        public async Task AddAsync(RoomImageAddRequest roomImageAddRequest)
        {
            RoomImage image = _mapper.Map<RoomImage>(roomImageAddRequest);
            image.FileName = roomImageAddRequest.File.FileName;
            image.FilePath = _fileServerPath.Path;

            await _roomImageRepository.CreateAsync(image);
        }
    }
}
