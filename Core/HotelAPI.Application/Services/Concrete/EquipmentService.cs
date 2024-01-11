using AutoMapper;
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
            await _equipmentRepository.DeActivate(equipment);
        }

        public async Task EditAsync(EquipmentUpdateRequest equipmentUpdateRequest)
        {
            var map = _mapper.Map<Equipment>(equipmentUpdateRequest);
            await _equipmentRepository.UpdateAsync(map);
        }

        public async Task<EquipmentUpdateRequest> GetForUpdateById(int id)
        {
            Equipment equipment = await _equipmentRepository.FindByIdAsync(id);
            EquipmentUpdateRequest equipmentUpdateRequest = _mapper.Map<EquipmentUpdateRequest>(equipment); ;
            return equipmentUpdateRequest;
        }

        public async Task<List<EquipmentTableResponse>> GetTable()
        {
            var equipments = _equipmentRepository.FindAllAsync();
            return _mapper.Map<List<EquipmentTableResponse>>(equipments);
        }
    }
}
