namespace HotelAPI.Domain.Entities
{
    public class HotelImage : BaseEntity
    {
        public string FileName { get; set; }
        public string? FilePath { get; set; }
        public string File { get; set;  }
        public FileType FileType { get; set; }

        //Relations
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

    }
}
