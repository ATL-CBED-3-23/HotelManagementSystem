using AutoMapper;
using HotelAPI.Application.DTOs.HotelImages;
using HotelAPI.Application.Helpers;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using Microsoft.Extensions.Options;

namespace HotelAPI.Application.Services.Concrete
{
    public class HotelImageService : IHotelImageService
    {
        private readonly IHotelImageRepository _hotelImageRepository;
        private readonly IMapper _mapper;
        private readonly FileServerPath _fileServerPath;

        public HotelImageService(IHotelImageRepository hotelImageRepository, IMapper mapper, IOptionsSnapshot<FileServerPath> filePath)
        {
            _hotelImageRepository = hotelImageRepository;
            _mapper = mapper;
            _fileServerPath = filePath.Value;
        }

        public async Task AddAsync(HotelImageAddRequest hotelImageAddRequest)
        {
            HotelImage image = _mapper.Map<HotelImage>(hotelImageAddRequest);
           // image.FileName = hotelImageAddRequest.File.FileName;
       //     image.FilePath = _fileServerPath.Path;

            await _hotelImageRepository.CreateAsync(image);
        }
    }
}
