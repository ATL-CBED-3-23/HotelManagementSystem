using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.DTOs.HotelUserRoles
{
    public class RoleAddRequest:IMapTo<HotelUserRole>
    {
        public string Name { get; set; }
    }
}
