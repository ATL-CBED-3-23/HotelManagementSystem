using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.DTOs.HotelUsers
{
    public class UserAddRequest:IMapTo<HotelUser>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

    }
}
