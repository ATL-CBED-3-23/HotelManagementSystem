using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using HotelAPI.Persistence.AppDbContext;

namespace HotelAPI.Infrastructure.Repositories
{
    public class RoomImageRepository : RepositoryBase<RoomImage>, IRoomImageRepository
    {
        public RoomImageRepository(HotelAppContext context) : base(context)
        {
        }
    }
}
