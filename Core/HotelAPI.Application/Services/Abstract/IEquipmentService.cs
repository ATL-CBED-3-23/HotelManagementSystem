using HotelAPI.Application.DTOs.Equipments;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IEquipmentService
    {
        Task AddAsync(EquipmentAddRequest equipmentAddRequest);
        Task EditAsync(EquipmentUpdateRequest equipmentUpdateRequest);
        Task<EquipmentTableResponse> GetById(int id);
        Task<List<EquipmentTableResponse>> GetTable();
        Task DeleteByIdAsync(int id);
    }
}
