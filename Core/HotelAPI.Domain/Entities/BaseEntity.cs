﻿namespace HotelAPI.Domain.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public EntityStatus EntityStatus { get; set; } = EntityStatus.Active;
}

