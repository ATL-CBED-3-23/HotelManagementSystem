namespace HotelAPI.Domain.Entities
{
    public class HotelImage : BaseEntity
    {
        public string FileName { get; set; }
        public string? FilePath { get; set; }
        public string FileBase64 { get; set;  }

        //Relations
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

    }
}
