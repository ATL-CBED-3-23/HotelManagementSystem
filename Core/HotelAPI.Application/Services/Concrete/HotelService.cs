using AutoMapper;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Interfaces;

namespace HotelAPI.Application.Services.Concrete
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IMapper _mapper;

        public HotelService(IHotelRepository hotelRepository, IMapper mapper)
        {
            _mapper = mapper;
            _hotelRepository = hotelRepository;
        }

    }
}
