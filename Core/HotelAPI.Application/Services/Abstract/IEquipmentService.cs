using HotelAPI.Application.DTOs.Equipments;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IEquipmentService
    {
        Task AddAsync(EquipmentAddRequest equipmentAddRequest);
        Task EditAsync(EquipmentUpdateRequest equipmentUpdateRequest);
        Task<EquipmentTableResponse> GetByIdAsync(int id);
        Task<List<EquipmentTableResponse>> GetTableAsync();
        Task DeleteByIdAsync(int id);
    }
}
