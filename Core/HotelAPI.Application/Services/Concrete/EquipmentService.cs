using AutoMapper;
using HotelAPI.Application.DTOs.Cities;
using HotelAPI.Application.DTOs.Equipments;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;

namespace HotelAPI.Application.Services.Concrete
{
    public class EquipmentService : IEquipmentService
    {
        private readonly IEquipmentRepository _equipmentRepository;
        private readonly IMapper _mapper;

        public EquipmentService(IEquipmentRepository equipmentRepository, IMapper mapper)
        {
            _mapper = mapper;
            _equipmentRepository = equipmentRepository;
        }
        public async Task AddAsync(EquipmentAddRequest equipmentAddRequest)
        {
            var map = _mapper.Map<Equipment>(equipmentAddRequest);

            await _equipmentRepository.CreateAsync(map);
        }
        public async Task DeleteByIdAsync(int id)
        {
            Equipment equipment = await _equipmentRepository.FindByIdAsync(id);
            await _equipmentRepository.DeActivateAsync(equipment);
        }
        public async Task EditAsync(EquipmentUpdateRequest equipmentUpdateRequest)
        {
            var map = _mapper.Map<Equipment>(equipmentUpdateRequest);
            await _equipmentRepository.UpdateAsync(map);
        }
        public async Task<EquipmentTableResponse> GetForEditByIdAsync(int id)
        {
            Equipment equipment = await _equipmentRepository.FindByIdAsync(id);
            EquipmentTableResponse equipmentTableResponse = _mapper.Map<EquipmentTableResponse>(equipment); ;
            return equipmentTableResponse;
        }
        public async Task<EquipmentTableView> GetByIdAsync(int id)
        {
            Equipment city = await _equipmentRepository.FindByIdAsync(id);
            EquipmentTableView equipmentTableView = _mapper.Map<EquipmentTableView>(city);
            return equipmentTableView;
        }
        public async Task<List<EquipmentTableResponse>> GetTableAsync()
        {
            var equipments = await _equipmentRepository.FindAllActiveAsync();
            return _mapper.Map<List<EquipmentTableResponse>>(equipments);
        }
    }
}
