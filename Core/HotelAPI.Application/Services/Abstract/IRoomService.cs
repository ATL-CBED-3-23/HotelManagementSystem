using HotelAPI.Application.DTOs.Rooms;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IRoomService
    {
        Task AddAsync(RoomAddRequest roomAddRequest);
        Task EditAsync(RoomUpdateRequest roomUpdateRequest);
        Task<RoomTableResponse> GetForUpdateById(int id);
        Task<List<RoomTableResponse>> GetTable();
        Task DeleteByIdAsync(int id);
    }
}
