
using HotelAPI.Application.DTOs.Reservations;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IReservationService
    {
        Task<string> AddAsync(ReservationAddRequest reservationAddRequest);
        Task EditAsync(ReservationUpdateRequest reservationUpdateRequest);
        Task<ReservationTableResponse> GetById(int id);
        Task<List<ReservationTableResponse>> GetTable();
        Task DeleteByIdAsync(int id);
        Task<List<ReservationTableResponse>> GetReservationsByUser(int userId);
        Task<List<ReservationTableResponse>> GetReservationsByGuestUser();
    }
}
