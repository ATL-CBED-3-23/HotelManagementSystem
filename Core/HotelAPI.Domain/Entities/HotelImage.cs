using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAPI.Domain.Entities
{

    [Table("HotelImages", Schema = "Hotel")]

    public class HotelImage : BaseEntity
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }

        //Relations
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

    }
}
