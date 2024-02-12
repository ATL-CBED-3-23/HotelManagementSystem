using AutoMapper;
using HotelAPI.Application.DTOs.HotelUserImages;
using HotelAPI.Application.Helpers;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using Microsoft.Extensions.Options;

namespace HotelAPI.Application.Services.Concrete
{
    public class HotelUserImageService : IHotelUserImageService
    {
        private readonly IHotelUserImageRepository _hotelUserImageRepository;
        private readonly IMapper _mapper;
        private readonly FileServerPath _fileServerPath;

        public HotelUserImageService(IHotelUserImageRepository hotelUserImageRepository, IMapper mapper, IOptionsSnapshot<FileServerPath> filePath)
        {
            _hotelUserImageRepository = hotelUserImageRepository;
            _mapper = mapper;
            _fileServerPath = filePath.Value;
        }

        public async Task AddAsync(HotelUserImageAddRequest hotelUserImageAddRequest)
        {
            HotelUserImage image = _mapper.Map<HotelUserImage>(hotelUserImageAddRequest);
           // image.FileName = hotelUserImageAddRequest.File.FileName;
           // image.FilePath = _fileServerPath.Path;

            await _hotelUserImageRepository.CreateAsync(image);
        }
    }
}
