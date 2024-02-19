using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAPI.Domain.Entities
{
    [Table("HotelUserImages", Schema = "Hotel")]
    public class HotelUserImage : BaseEntity
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }

        //Relations
        public int HotelUserId { get; set; }
        public HotelUser HotelUser { get; set; }

    }
}
