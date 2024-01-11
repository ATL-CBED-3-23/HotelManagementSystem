using AutoMapper;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Interfaces;

namespace HotelAPI.Application.Services.Concrete
{
    public class ReservatorService : IReservatorService
    {
        private readonly IReservatorRepository _reservatorRepository;
        private readonly IMapper _mapper;

        public ReservatorService(IReservatorRepository reservatorRepository, IMapper mapper)
        {
            _mapper = mapper;
            _reservatorRepository = reservatorRepository;
        }

    }
}
