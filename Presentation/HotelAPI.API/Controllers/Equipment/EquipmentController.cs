using HotelAPI.Application.DTOs.Countries;
using HotelAPI.Application.DTOs.Equipments;
using HotelAPI.Application.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.Equipment
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentService _equipmentService;

        public EquipmentController(IEquipmentService EquipmentService)
        {
            _equipmentService = EquipmentService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(EquipmentAddRequest equipmentAddRequest)
        {
            await _equipmentService.AddAsync(equipmentAddRequest);
            return Ok();
        }

        [HttpGet("GetTable")]
        public async Task<IActionResult> GetTable()
        {
            var list = await _equipmentService.GetTable();
            return Ok(list);
        }

        [HttpGet("GetForEdit/{id}")]
        public async Task<IActionResult> GetForEdit(int id)
        {
            var item = await _equipmentService.GetForUpdateById(id);
            return Ok(item);
        }

        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(EquipmentUpdateRequest equipmentUpdateRequest)
        {
            await _equipmentService.EditAsync(equipmentUpdateRequest);
            return Ok();
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _equipmentService.DeleteByIdAsync(id);
            return Ok();
        }
    }
}
