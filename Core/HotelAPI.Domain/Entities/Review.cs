using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAPI.Domain.Entities;
[Table("Reviews", Schema = "Hotel")]
public class Review:BaseEntity
{
    public string Content { get; set; }



    //Relations
    public int ReservatorId { get; set; }
    public Reservator Reservator { get; set; }
    public int HotelId { get; set; }
    public Hotel Hotel { get; set; }
}
