using Microsoft.AspNetCore.Identity;

namespace HotelAPI.Domain.Entities
{
    public class HotelUserRole:IdentityRole<int>
    {
        public EntityStatus EntityStatus { get; set; } = EntityStatus.Active;
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
