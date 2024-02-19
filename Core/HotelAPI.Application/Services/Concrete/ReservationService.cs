using AutoMapper;
using HotelAPI.Application.DTOs.HotelUsers;
using HotelAPI.Application.DTOs.Reservations;
using HotelAPI.Application.DTOs.Rooms;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace HotelAPI.Application.Services.Concrete
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IRoomRepository _roomRepository;
        private readonly UserManager<HotelUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ClaimsPrincipal _user;

        public ReservationService(IReservationRepository reservationRepository, IMapper mapper, IRoomRepository roomRepository,
            UserManager<HotelUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _mapper = mapper;
            _reservationRepository = reservationRepository;
            _roomRepository = roomRepository;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
        }

        public async Task<string> AddAsync(ReservationAddRequest reservationAddRequest)
        {
            var reservation = _mapper.Map<Reservation>(reservationAddRequest);
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            reservation.HotelUserId = int.Parse(userId);
            reservation.Room = await _roomRepository.FindByIdAsync(reservationAddRequest.RoomId);
            bool isRoomAvailable = reservation.Room.RoomState == RoomState.Available;
            if (!isRoomAvailable)
            {
                return "Room is not available";
            }
            reservation.Room.RoomState = RoomState.NoAvailable;
            await _roomRepository.UpdateAsync(reservation.Room);
            await _reservationRepository.CreateAsync(reservation);
            

            return "Room is reserved successfully";
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

        public async Task<ReservationTableResponse> GetById(int id)
        {
            Reservation reservation = await _reservationRepository.FindByIdAsync(id);
            ReservationTableResponse reservationTableResponse = _mapper.Map<ReservationTableResponse>(reservation);
            return reservationTableResponse;
        }

        public async Task<List<ReservationTableResponse>> GetTable()
        {
            var reservations = await _reservationRepository.FindAllAsync();
            return _mapper.Map<List<ReservationTableResponse>>(reservations);
        }
        public async Task<List<ReservationTableResponse>> GetReservationsByGuestUser()
        {
            List<Reservation> reservations = await _reservationRepository.FindAllAsync();
            List<Room> rooms = await _roomRepository.FindAllAsync();
            List<HotelUser> users = _userManager.Users.ToList();
            int userId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

            var result = from reservation in reservations
                         join user in users on reservation.HotelUserId equals user.Id
                         join room in rooms on reservation.RoomId equals room.Id
                         where user.Id == userId
                         select new ReservationTableResponse()
                         {
                             Id = reservation.Id,
                             CheckInDate = reservation.CheckInDate,
                             CheckOutDate = reservation.CheckOutDate,
                             HotelUser = user.UserName,
                             Room = room.Number
                         };

            return result.ToList();

        }
        public async Task<List<ReservationTableResponse>> GetReservationsByUser(int userId)
        {
            List<Reservation> reservations = await _reservationRepository.FindAllAsync();
            List<Room> rooms = await _roomRepository.FindAllAsync();
            List<HotelUser> users = _userManager.Users.ToList();

            var result = from reservation in reservations
                         join user in users on reservation.HotelUserId equals user.Id
                         join room in rooms on reservation.RoomId equals room.Id
                         where user.Id == userId
                         select new ReservationTableResponse()
                         {
                             Id = reservation.Id,
                             CheckInDate = reservation.CheckInDate,
                             CheckOutDate = reservation.CheckOutDate,
                             HotelUser = user.UserName,
                             Room = room.Number
                         };

            return result.ToList();

        }

    }
}
