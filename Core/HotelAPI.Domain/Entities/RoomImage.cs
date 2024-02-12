using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAPI.Domain.Entities
{
    [Table("RoomImages", Schema = "Hotel")]
    public class RoomImage : BaseEntity
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }

        //Relations
        public int RoomId {  get; set; }
        public Room Room { get; set; }

    }
}
