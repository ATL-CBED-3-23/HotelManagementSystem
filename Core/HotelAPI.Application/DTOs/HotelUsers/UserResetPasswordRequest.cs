﻿using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.DTOs.HotelUsers
{
    public class UserResetPasswordRequest 
    {
        public int Id { get; set; }
        public string NewPassword { get; set; }
    }
}
