using AutoMapper;
using HotelAPI.Application.DTOs.Reservations;
using HotelAPI.Application.DTOs.Reservators;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
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

        public async Task AddAsync(ReservationAddRequest reservationAddRequest)
        {
            var map = _mapper.Map<Reservation>(reservationAddRequest);

            await _reservationRepository.CreateAsync(map);
        }

        public async Task DeleteByIdAsync(int id)
        {
            Reservation Reservation = await _reservationRepository.FindByIdAsync(id);
            await _reservationRepository.DeActivate(Reservation);
        }

        public async Task EditAsync(ReservationUpdateRequest reservationUpdateRequest)
        {
            var map = _mapper.Map<Reservation>(reservationUpdateRequest);
            await _reservationRepository.UpdateAsync(map);
        }

        public async Task<ReservationUpdateRequest> GetForUpdateById(int id)
        {
            Reservation reservation = await _reservationRepository.FindByIdAsync(id);
            ReservationUpdateRequest reservationUpdateRequest = _mapper.Map<ReservationUpdateRequest>(reservation);
            return reservationUpdateRequest;
        }

        public async Task<List<ReservationTableResponse>> GetTable()
        {
            var reservations = _reservationRepository.FindAllAsync();
            return _mapper.Map<List<ReservationTableResponse>>(reservations);
        }
    }
}
