﻿using HotelAPI.Application.DTOs.Equipments;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Application.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.API.Controllers.Equipment
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Authorize(Roles = AllowedRolesForController.Admin_and_Staff_and_User)]

    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentService _equipmentService;

        public EquipmentController(IEquipmentService EquipmentService)
        {
            _equipmentService = EquipmentService;
        }
        
    }
}
