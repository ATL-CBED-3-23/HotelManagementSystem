﻿using HotelAPI.Application.DTOs.Rooms;

namespace HotelAPI.Application.DTOs.Equipments
{
    public class EquipmentTableResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        //Relations
        public List<RoomTableResponse> Rooms { get; set; }
    }
}
