using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.DTOs.Equipments;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IEquipmentService
    {
        Task AddAsync(EquipmentAddRequest equipmentAddRequest);
        Task EditAsync(EquipmentUpdateRequest equipmentUpdateRequest);
        Task<EquipmentTableResponse> GetForEditByIdAsync(int id);
        Task<EquipmentTableView> GetByIdAsync(int id);
        Task<List<EquipmentTableResponse>> GetTableAsync();
        Task DeleteByIdAsync(int id);
    }
}
