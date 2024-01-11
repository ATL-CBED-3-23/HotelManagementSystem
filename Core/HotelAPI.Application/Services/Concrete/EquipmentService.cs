using AutoMapper;
using HotelAPI.Application.Services.Abstract;
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

    }
}
