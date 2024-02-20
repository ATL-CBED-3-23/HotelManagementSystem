using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.DTOs.HotelRating
{
    public class HotelRatingAddRequest
    {

        public Rating Rating { get; set; }
        public int HotelId { get; set; }
        public int UserId { get; set; }

    }
}
