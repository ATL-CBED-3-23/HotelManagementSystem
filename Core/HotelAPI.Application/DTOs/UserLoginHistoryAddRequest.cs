using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.DTOs
{
    public class UserLoginHistoryAddRequest : IMapTo<UserLoginHistory>
    {
        public DateTime LoginDate { get; set; }

        //Relations
        public int HotelUserId { get; set; }
    }
}
