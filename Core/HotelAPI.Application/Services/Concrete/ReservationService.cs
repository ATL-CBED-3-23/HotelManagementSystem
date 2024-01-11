using AutoMapper;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Interfaces;

namespace HotelAPI.Application.Services.Concrete
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;

        public ReservationService(IReservationRepository reservationRepository, IMapper mapper)
        {
            _mapper = mapper;
            _reservationRepository = reservationRepository;
        }

    }
}
