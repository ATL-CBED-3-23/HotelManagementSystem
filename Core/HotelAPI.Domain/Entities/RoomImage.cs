namespace HotelAPI.Domain.Entities
{
    public class RoomImage : BaseEntity
    {
        public string ImagePath { get; set; }

        //Relations
        public int RoomId {  get; set; }
        public Room Room { get; set; }

    }
}
