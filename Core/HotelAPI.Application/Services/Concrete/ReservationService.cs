using AutoMapper;
using HotelAPI.Application.DTOs.HotelUsers;
using HotelAPI.Application.DTOs.Reservations;
using HotelAPI.Application.DTOs.Rooms;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace HotelAPI.Application.Services.Concrete
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IRoomRepository _roomRepository;
        private readonly UserManager<HotelUser> _userManager;

        private readonly IMapper _mapper;

        public ReservationService(IReservationRepository reservationRepository, IMapper mapper, IRoomRepository roomRepository, UserManager<HotelUser> userManager)
        {
            _mapper = mapper;
            _reservationRepository = reservationRepository;
            _roomRepository = roomRepository;
            _userManager = userManager;
        }

        public async Task AddAsync(ReservationAddRequest reservationAddRequest)
        {

            var reservation = _mapper.Map<Reservation>(reservationAddRequest);
            //bool isRoomAvailable = reservation.Room.RoomState == RoomState.Available;
            //if (!isRoomAvailable)
            //{

            //}

            await _reservationRepository.CreateAsync(reservation);
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

        public async Task<List<ReservationTableResponse>> GetReservationsByUser(int userId)
        {
            List<Reservation> reservations = await _reservationRepository.FindByConditionAsync(r => r.HotelUserId == userId);
            List<Room> rooms = await _roomRepository.FindAllAsync();
            List<HotelUser> users = _userManager.Users.ToList();

            var result = from reservation in reservations
                         join user in users on reservation.HotelUserId equals user.Id
                         join room in rooms on reservation.RoomId equals room.Id
                         select new ReservationTableResponse()
                         {
                             Id = reservation.Id,
                             CheckInDate = reservation.CheckInDate,
                             CheckOutDate = reservation.CheckOutDate,
                             HotelUser = new UserTableResponse()
                             {
                                 Id = user.Id,
                                 FullName = $"{user.FirstName} {user.LastName}",
                                 Email = user.Email,
                                 UserName = user.UserName
                             },
                             Room = new RoomTableResponse()
                             {
                                 Id = room.Id,
                                 Number = room.Number,
                                 Floor = room.Floor,
                                 Price = room.Price,
                             }
                         };

            return result.ToList();

        }

    }
}
