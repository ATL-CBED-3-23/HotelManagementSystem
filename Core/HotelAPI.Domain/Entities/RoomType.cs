using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAPI.Domain.Entities;
[Table("RoomTypes", Schema = "Hotel")]
public class RoomType:BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }

    //Relations
    public List<Room> Rooms { get; set; }

}
