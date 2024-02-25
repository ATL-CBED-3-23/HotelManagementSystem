using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAPI.Domain.Entities;
[Table("Reviews", Schema = "Hotel")]
public class Review:BaseEntity
{
    public string Content { get; set; }

    //Relations
    public int HotelUserId { get; set; }
    public HotelUser HotelUser { get; set; }
    public int HotelId { get; set; }
    public Hotel Hotel { get; set; }
}
