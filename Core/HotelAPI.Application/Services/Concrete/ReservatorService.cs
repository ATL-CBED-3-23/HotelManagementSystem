using AutoMapper;
using HotelAPI.Application.DTOs.Reservators;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
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

        public async Task AddAsync(ReservatorAddRequest reservatorAddRequest)
        {
            var map = _mapper.Map<Reservator>(reservatorAddRequest);

            await _reservatorRepository.CreateAsync(map);
        }

        public async Task DeleteByIdAsync(int id)
        {
            Reservator reservator = await _reservatorRepository.FindByIdAsync(id);
            await _reservatorRepository.DeActivate(reservator);
        }

        public async Task EditAsync(ReservatorUpdateRequest reservatorUpdateRequest)
        {
            var map = _mapper.Map<Reservator>(reservatorUpdateRequest);
            await _reservatorRepository.UpdateAsync(map);
        }

        public async Task<ReservatorTableResponse> GetById(int id)
        {
            Reservator reservator = await _reservatorRepository.FindByIdAsync(id);
            ReservatorTableResponse reservatorTableResponse = _mapper.Map<ReservatorTableResponse>(reservator);
            return reservatorTableResponse;
        }

        public async Task<List<ReservatorTableResponse>> GetTable()
        {
            var reservators = _reservatorRepository.FindAllAsync();
            return _mapper.Map<List<ReservatorTableResponse>>(reservators);
        }
    }
}
