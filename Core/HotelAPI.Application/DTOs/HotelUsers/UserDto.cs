using HotelAPI.Application.DTOs.HotelUserRoles;
using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.DTOs.HotelUsers
{
    public class UserDto:IMapTo<HotelUser>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public IList<string> Roles { get; set; }
    }
}
