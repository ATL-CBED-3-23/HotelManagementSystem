using AutoMapper;
using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.DTOs.HotelImages;
using HotelAPI.Application.DTOs.HotelRatings;
using HotelAPI.Application.DTOs.Hotels;
using HotelAPI.Application.DTOs.Rooms;
using HotelAPI.Application.DTOs.RoomTypes;
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
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;
        private readonly IHotelRatingRepository _ratingRepository;

        public HotelService(IHotelRatingRepository hotelRating, IHotelRepository hotelRepository, IHotelImageRepository hotelImageRepository,
            IMapper mapper, ICityRepository cityRepository, ICountryRepository countryRepository, IRoomRepository roomRepository)
        {
            _mapper = mapper;
            _hotelRepository = hotelRepository;
            _cityRepository = cityRepository;
            _countryRepository = countryRepository;
            _hotelImageRepository = hotelImageRepository;
            _ratingRepository = hotelRating;
            _roomRepository = roomRepository;
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
            var hotels = await _hotelRepository.FindAllActiveAsync();
            var images = await _hotelImageRepository.FindAllActiveAsync();
            var rooms = await _roomRepository.FindAllActiveAsync();
            var result = from hotel in hotels
                         join image in images on hotel.Id equals image.HotelId
                         join room in rooms on hotel.Id equals room.HotelId
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
                             City = _mapper.Map<CityTableResponse>(hotel.City),
                             HotelImages = hotel.HotelImages.Select(x => new HotelImageTableResponse()
                             {
                                 Id = x.Id,
                                 FileName = x.FileName,
                                 FileBase64 = Convert.ToBase64String(FileHelper.GetPhoto(image.FileName))
                             }).ToList(),
                             Rooms = hotel.Rooms.Select(r => new RoomTableResponse()
                             {
                                 Id = r.Id,
                                 Number = r.Number,
                                 Floor = r.Floor,
                                 Phone = r.Phone,
                                 Price = r.Price,
                                 RoomState = r.RoomState,
                                 RoomType = _mapper.Map<RoomTypeTableResponse>(r.RoomType)
                             }).ToList(),
                         };

            return result.FirstOrDefault();
        }
        public async Task<HotelTableView> GetByIdAsync(int id)
        {
            var hotels = await _hotelRepository.FindAllActiveAsync();
            var images = await _hotelImageRepository.FindAllActiveAsync();
            var rooms = await _roomRepository.FindAllActiveAsync();
            var result = from hotel in hotels
                         join image in images on hotel.Id equals image.HotelId
                         join room in rooms on hotel.Id equals room.HotelId
                         where hotel.Id == id
                         select new HotelTableView()
                         {
                             Id = hotel.Id,
                             Address = hotel.Address,
                             Email = hotel.Email,
                             Name = hotel.Name,
                             PhoneNumber = hotel.PhoneNumber,
                             WebSite = hotel.WebSite,
                             Grade = hotel.Grade,
                             City = _mapper.Map<CityTableResponse>(hotel.City),
                             HotelImages = hotel.HotelImages.Select(x => new HotelImageTableResponse()
                             {
                                 Id = x.Id,
                                 FileName = x.FileName,
                                 FileBase64 = Convert.ToBase64String(FileHelper.GetPhoto(image.FileName))
                             }).ToList(),
                             Rooms = hotel.Rooms.Select(r => new RoomTableResponse()
                             {
                                 Id = r.Id,
                                 Number = r.Number,
                                 Floor = r.Floor,
                                 Phone = r.Phone,
                                 Price = r.Price,
                                 RoomState = r.RoomState,
                                 RoomType = _mapper.Map<RoomTypeTableResponse>(r.RoomType)
                             }).ToList(),
                         };

            return result.FirstOrDefault();
        }
        public async Task<List<HotelTableResponse>> GetTableAsync()
        {
            var hotels = await _hotelRepository.FindAllActiveAsync();
            var images = await _hotelImageRepository.FindAllActiveAsync();
            var rooms = await _roomRepository.FindAllActiveAsync();
            var result = from hotel in hotels
                         join image in images on hotel.Id equals image.HotelId
                         join room in rooms on hotel.Id equals room.HotelId
                         select new HotelTableResponse()
                         {
                             Id = hotel.Id,
                             Address = hotel.Address,
                             Email = hotel.Email,
                             Name = hotel.Name,
                             PhoneNumber = hotel.PhoneNumber,
                             WebSite = hotel.WebSite,
                             Grade = hotel.Grade,
                             City = _mapper.Map<CityTableResponse>(hotel.City),
                             HotelImages = hotel.HotelImages.Select(x => new HotelImageTableResponse()
                             {
                                 Id = x.Id,
                                 FileName = x.FileName,
                                 FileBase64 = Convert.ToBase64String(FileHelper.GetPhoto(image.FileName))
                             }).ToList(),
                             Rooms =hotel.Rooms.Select(r => new RoomTableResponse()
                             {
                                 Id=r.Id,
                                 Number= r.Number,
                                 Floor=r.Floor,
                                 Phone=r.Phone,
                                 Price=r.Price,
                                 RoomState=r.RoomState,
                                 RoomType=_mapper.Map<RoomTypeTableResponse>(r.RoomType)
                             }).ToList(),
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
        public async Task<List<HotelTableResponseForDropdown>> GetTableForDropdownByConditionAsync(int cityId)
        {
            List<Hotel> hotels = await _hotelRepository.FindByConditionAsync(c => c.EntityStatus == EntityStatus.Active && c.CityId == cityId);
            List<HotelTableResponseForDropdown> hotelTableResponseForDropdown = _mapper.Map<List<HotelTableResponseForDropdown>>(hotels);
            return hotelTableResponseForDropdown;
        }
        public async Task<List<HotelTableResponseForDropdown>> GetTableForDropdownAsync()
        {
            List<Hotel> hotels = await _hotelRepository.FindAllActiveAsync();
            List<HotelTableResponseForDropdown> hotelTableResponseForDropdown = _mapper.Map<List<HotelTableResponseForDropdown>>(hotels);
            return hotelTableResponseForDropdown;
        }


    }
}
