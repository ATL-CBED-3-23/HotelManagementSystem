using HotelAPI.Application.DTOs.RoomTypes;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IRoomTypeService
    {
        Task AddAsync(RoomTypeAddRequest roomTypeAddRequest);
        Task EditAsync(RoomTypeUpdateRequest roomTypeUpdateRequest);
        Task<RoomTypeTableResponse> GetByIdAsync(int id);
        Task<List<RoomTypeTableResponse>> GetTableAsync();
        Task DeleteByIdAsync(int id);
    }
}
