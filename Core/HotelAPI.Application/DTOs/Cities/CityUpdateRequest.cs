using HotelAPI.Application.Mappings;
using HotelAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.DTOs.Cities
{
    public class CityUpdateRequest:IMapTo<City>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PostalCode { get; set; }

        //Relations
        
    }
}
