﻿using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.DTOs.RoomTypes
{
    public class RoomTypeTableResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relations
        public List<Room> Rooms { get; set; }

    }
}
