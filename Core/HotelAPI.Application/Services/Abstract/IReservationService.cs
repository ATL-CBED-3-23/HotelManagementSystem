
using HotelAPI.Application.DTOs.Reservations;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IReservationService
    {
        Task AddAsync(ReservationAddRequest reservationAddRequest);
        Task EditAsync(ReservationUpdateRequest reservationUpdateRequest);
        Task<ReservationUpdateRequest> GetForUpdateById(int id);
        Task<List<ReservationTableResponse>> GetTable();
        Task DeleteByIdAsync(int id);
    }
}
