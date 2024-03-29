﻿
using HotelAPI.Application.DTOs.Reservations;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IReservationService
    {
        Task<string> AddAsync(ReservationAddRequest reservationAddRequest);
        Task EditAsync(ReservationUpdateRequest reservationUpdateRequest);
        Task<ReservationTableResponse> GetByIdAsync(int id);
        Task<List<ReservationTableResponse>> GetTableAsync();
        Task DeleteByIdAsync(int id);
        Task<List<ReservationTableResponse>> GetReservationsByUserAsync(int userId);
        Task<List<ReservationTableResponse>> GetReservationsByGuestUserAsync();
    }
}
