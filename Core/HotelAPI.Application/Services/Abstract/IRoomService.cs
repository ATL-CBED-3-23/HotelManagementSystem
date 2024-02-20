using HotelAPI.Application.DTOs.Rooms;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IRoomService
    {
        Task AddAsync(RoomAddRequest roomAddRequest);
        Task EditAsync(RoomUpdateRequest roomUpdateRequest);
        Task<RoomTableResponse> GetByIdAsync(int id);
        Task<List<RoomTableResponse>> GetTableAsync();
        Task DeleteByIdAsync(int id);
    }
}
