using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAPI.Domain.Entities;
[Table("Equipments", Schema = "Hotel")]
public class Equipment:BaseEntity
{
    public string Name { get; set; }
    public int Count { get; set; }

    //Relations
    public List<Room> Rooms { get; set; }   
  
}
