using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Domain.Entities
{
    public class UserLoginHistory : BaseEntity
    {
        public DateTime LoginDate { get; set; }

        //Relations
        public int HotelUserId { get; set; }
        public HotelUser HotelUser { get; set; }

    }
}
