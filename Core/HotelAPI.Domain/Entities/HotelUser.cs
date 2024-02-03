using Microsoft.AspNetCore.Identity;

namespace HotelAPI.Domain.Entities
{
    public class HotelUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EntityStatus EntityStatus { get; set; } = EntityStatus.Active;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public List<Reservation> Reservations { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
