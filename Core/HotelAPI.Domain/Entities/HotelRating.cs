namespace HotelAPI.Domain.Entities
{
    public class HotelRating : BaseEntity
    {
        public Rating Rating { get; set; }

        //Relations
        public Hotel Hotel { get; set; }
        public int HotelId { get; set; }
        public HotelUser User { get; set; }
        public int UserId { get; set; }


    }
}
