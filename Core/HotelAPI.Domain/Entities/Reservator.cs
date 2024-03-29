﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAPI.Domain.Entities;
[Table("Reservators", Schema = "Hotel")]
public class Reservator:BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    //Relations
   // public List<Reservation> Reservations { get; set; }
  //  public List<Review> Reviews { get; set; }
}
