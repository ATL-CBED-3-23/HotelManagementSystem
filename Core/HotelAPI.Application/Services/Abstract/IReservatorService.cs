using HotelAPI.Application.DTOs.Reservators;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IReservatorService
    {
        Task AddAsync(ReservatorAddRequest reservatorAddRequest);
        Task EditAsync(ReservatorUpdateRequest reservatorUpdateRequest);
        Task<ReservatorTableResponse> GetByIdAsync(int id);
        Task<List<ReservatorTableResponse>> GetTableAsync();
        Task DeleteByIdAsync(int id);
    }
}
