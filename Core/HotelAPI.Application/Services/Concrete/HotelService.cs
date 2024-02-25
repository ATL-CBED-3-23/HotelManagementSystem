using AutoMapper;
using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.DTOs.HotelImages;
using HotelAPI.Application.DTOs.HotelRatings;
using HotelAPI.Application.DTOs.Hotels;
using HotelAPI.Application.Helpers;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;

namespace HotelAPI.Application.Services.Concrete
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IHotelImageRepository _hotelImageRepository;
        private readonly ICountryRepository _countryRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;
        private readonly IHotelRatingRepository _ratingRepository;

        public HotelService(IHotelRatingRepository hotelRating, IHotelRepository hotelRepository, IHotelImageRepository hotelImageRepository, IMapper mapper, ICityRepository cityRepository, ICountryRepository countryRepository)
        {
            _mapper = mapper;
            _hotelRepository = hotelRepository;
            _cityRepository = cityRepository;
            _countryRepository = countryRepository;
            _hotelImageRepository = hotelImageRepository;
            _ratingRepository = hotelRating;
        }

        public async Task AddAsync(HotelAddRequest hotelAddRequest)
        {
            foreach (var image in hotelAddRequest.HotelImages)
            {
                byte[] bytes = Convert.FromBase64String(image.FileBase64);
                image.FileName = FileHelper.SavePhotoToFtp(bytes, image.FileName);
            }
            var map = _mapper.Map<Hotel>(hotelAddRequest);
            await _hotelRepository.CreateAsync(map);
        }
        public async Task DeleteByIdAsync(int id)
        {
            Hotel hotel = await _hotelRepository.FindByIdAsync(id);
            await _hotelRepository.DeActivateAsync(hotel);
        }
        public async Task EditAsync(HotelUpdateRequest hotelUpdateRequest)
        {

            foreach (var image in hotelUpdateRequest.HotelImages)
            {
                byte[] bytes = Convert.FromBase64String(image.FileBase64);
                image.FileName = FileHelper.SavePhotoToFtp(bytes, image.FileName);
            }
            var map = _mapper.Map<Hotel>(hotelUpdateRequest);
            await _hotelRepository.UpdateAsync(map);
        }
        public async Task<HotelTableResponse> GetForEditByIdAsync(int id)
        {
            var hotels = await _hotelRepository.FindAllAsync();
            var images = await _hotelImageRepository.FindAllAsync();
            var cities = await _cityRepository.FindAllAsync();
            var result = from hotel in hotels
                         join image in images on hotel.Id equals image.HotelId
                         join city in cities on hotel.CityId equals city.Id
                         where hotel.Id == id
                         select new HotelTableResponse()
                         {
                             Id = hotel.Id,
                             Address = hotel.Address,
                             Email = hotel.Email,
                             Name = hotel.Name,
                             PhoneNumber = hotel.PhoneNumber,
                             WebSite = hotel.WebSite,
                             Grade = hotel.Grade,
                             City = _mapper.Map<CityTableResponse>(city),
                             HotelImages = hotel.HotelImages.Select(x => new HotelImageTableResponse()
                             {
                                 Id = x.Id,
                                 FileName = x.FileName,
                                 FileBase64 = Convert.ToBase64String(FileHelper.GetPhoto(image.FileName))
                             }).ToList()

                         };

            return result.FirstOrDefault();
        }
        public Task<HotelTableView> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<List<HotelTableResponse>> GetTableAsync()
        {
            var hotels = await _hotelRepository.FindAllAsync();
            var images = await _hotelImageRepository.FindAllAsync();
            var cities = await _cityRepository.FindAllAsync();
            var result = from hotel in hotels
                         join image in images on hotel.Id equals image.HotelId
                         join city in cities on hotel.CityId equals city.Id
                         select new HotelTableResponse()
                         {
                             Id = hotel.Id,
                             Address = hotel.Address,
                             Email = hotel.Email,
                             Name = hotel.Name,
                             PhoneNumber = hotel.PhoneNumber,
                             WebSite = hotel.WebSite,
                             Grade = hotel.Grade,
                             City = _mapper.Map<CityTableResponse>(city),
                             HotelImages = hotel.HotelImages.Select(x => new HotelImageTableResponse()
                             {
                                 Id = x.Id,
                                 FileName = x.FileName,
                                 FileBase64 = Convert.ToBase64String(FileHelper.GetPhoto(image.FileName))
                             }).ToList()
                         };

            return result.ToList();
        }
        public async Task<List<HotelTableResponse>> GetHotelsByCityAsync(int cityId)
        {
            List<City> cities = await _cityRepository.FindAllAsync();
            List<Hotel> hotels = await _hotelRepository.FindAllAsync();
            List<HotelImage> images = await _hotelImageRepository.FindAllAsync();


            var result = from hotel in hotels
                         join image in images on hotel.Id equals image.HotelId
                         join city in cities on hotel.CityId equals city.Id
                         where city.Id == cityId
                         select new HotelTableResponse()
                         {
                             Id = hotel.Id,
                             Address = hotel.Address,
                             Email = hotel.Email,
                             Name = hotel.Name,
                             PhoneNumber = hotel.PhoneNumber,
                             WebSite = hotel.WebSite,
                             Grade = hotel.Grade,
                             City = _mapper.Map<CityTableResponse>(city),
                             HotelImages = hotel.HotelImages.Select(x => new HotelImageTableResponse()
                             {
                                 Id = x.Id,
                                 FileName = x.FileName,
                                 FileBase64 = Convert.ToBase64String(FileHelper.GetPhoto(image.FileName))
                             }).ToList()
                         };
            return result.ToList();
        }
        public async Task<List<HotelTableResponse>> GetHotelsByRoomCountAsync(int roomCount)
        {
            List<City> cities = await _cityRepository.FindAllAsync();
            List<Hotel> hotels = await _hotelRepository.FindByConditionAsync(h => h.Rooms.Count == roomCount);
            List<HotelImage> images = await _hotelImageRepository.FindAllAsync();


            var result = from hotel in hotels
                         join image in images on hotel.Id equals image.HotelId
                         join city in cities on hotel.CityId equals city.Id
                         select new HotelTableResponse()
                         {
                             Id = hotel.Id,
                             Address = hotel.Address,
                             Email = hotel.Email,
                             Name = hotel.Name,
                             PhoneNumber = hotel.PhoneNumber,
                             WebSite = hotel.WebSite,
                             Grade = hotel.Grade,
                             City = _mapper.Map<CityTableResponse>(city),
                             HotelImages = hotel.HotelImages.Select(x => new HotelImageTableResponse()
                             {
                                 Id = x.Id,
                                 FileName = x.FileName,
                                 FileBase64 = Convert.ToBase64String(FileHelper.GetPhoto(image.FileName))
                             }).ToList()
                         };
            return result.ToList();


        }

        public async Task AddRatingAsync(HotelRatingAddRequest AddRequest)
        {
            HotelRating hr = new HotelRating
            {
                Rating = AddRequest.Rating,
                UserId = AddRequest.UserId,
                HotelId = AddRequest.HotelId,
            };
            await _ratingRepository.CreateAsync(hr);
        }

        public async Task<double> GetHotelRatingAsync(int hotelId)
        {
            var ratings = await _ratingRepository.FindByConditionAsync(r => r.HotelId == hotelId && r.EntityStatus == EntityStatus.Active);
            double rating = 0;
            foreach (var item in ratings)
            {
                rating += Convert.ToDouble(item.Rating);
            }
            return rating / ratings.Count;

        }

        
    }
}
