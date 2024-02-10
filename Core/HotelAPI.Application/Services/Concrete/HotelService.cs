﻿using AutoMapper;
using HotelAPI.Application.DTOs.Hotels;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;

namespace HotelAPI.Application.Services.Concrete
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly ICountryRepository _countryRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public HotelService(IHotelRepository hotelRepository, IMapper mapper, ICityRepository cityRepository, ICountryRepository countryRepository)
        {
            _mapper = mapper;
            _hotelRepository = hotelRepository;
            _cityRepository = cityRepository;
            _countryRepository = countryRepository;
        }

        public async Task AddAsync(HotelAddRequest hotelAddRequest)
        {
            var map = _mapper.Map<Hotel>(hotelAddRequest);
            //base 64 string conver to byte and save to folder
            byte[] bytes = Convert.FromBase64String(hotelAddRequest.HotelImages.File);
            SavePhotoToFtp(bytes, hotelAddRequest.HotelImages.FileName,hotelAddRequest.HotelImages.FileType);
            await _hotelRepository.CreateAsync(map);
        }
        private string SavePhotoToFtp(byte[] imageBytes, string Name, FileType fileExtension)
        {
            try
            {
               // string fileExtension = "jpeg";
                string ftpPath = @"C:\AppImages"; //WebConfigurationManager.AppSettings["PhPersonPhotoPath"];
                string fileName = $"{Name}.{fileExtension}";
                string filePath = $"{ftpPath}/{fileName}";
                File.WriteAllBytes(filePath, imageBytes);
                return fileName;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return null;
            }
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
            HotelUpdateRequest hotelUpdateRequest = _mapper.Map<HotelUpdateRequest>(hotel);

            return hotelUpdateRequest;
        }

        public async Task<List<HotelTableResponse>> GetTable()
        {
            //var hotels= _hotelRepository.FindAllAsync();
            //return _mapper.Map<List<HotelTableResponse>>(hotels);
            List<Country> countries = await _countryRepository.FindAllAsync();
            List<City> cities = await _cityRepository.FindAllAsync();
            List<Hotel> hotels = await _hotelRepository.FindAllAsync();

            return hotels.Select(hotel => new HotelTableResponse
            {
                Id = hotel.Id,
                Address = hotel.Address,
                Email = hotel.Email,
                Name = hotel.Name,
                PhoneNumber = hotel.PhoneNumber,
                WebSite = hotel.WebSite,
                Grade = hotel.Grade,
                City = cities.FirstOrDefault(city => city.Id == hotel.CityId).Name

            }).ToList();
        }

        public async Task<List<HotelTableResponse>> GetHotelsByCity(int cityId)
        {
            List<City> cities = await _cityRepository.FindAllAsync();
            List<Hotel> hotels = await _hotelRepository.FindAllAsync();
            
            var result = from hotel in hotels
                         join city in cities on hotel.CityId equals city.Id
                         where city.Id == cityId
                         select new HotelTableResponse
                         {
                             Id = hotel.Id,
                             Address = hotel.Address,
                             Email = hotel.Email,
                             Name = hotel.Name,
                             PhoneNumber = hotel.PhoneNumber,
                             WebSite = hotel.WebSite,
                             Grade = hotel.Grade,
                             City = city.Name
                         };
            return result.ToList();
        }

        public async Task<List<HotelTableResponse>> GetHotelsByRoomCount(int roomCount)
        {
            List<City> cities = await _cityRepository.FindAllAsync();
            List<Hotel> hotels = await _hotelRepository.FindByConditionAsync(h => h.Rooms.Count == roomCount);

            var result = from hotel in hotels
                         join city in cities on hotel.CityId equals city.Id
                         select new HotelTableResponse
                         {
                             Id = hotel.Id,
                             Address = hotel.Address,
                             Email = hotel.Email,
                             Name = hotel.Name,
                             PhoneNumber = hotel.PhoneNumber,
                             WebSite = hotel.WebSite,
                             Grade = hotel.Grade,
                             City = city.Name
                         };
            return result.ToList();

        }
    }
}
