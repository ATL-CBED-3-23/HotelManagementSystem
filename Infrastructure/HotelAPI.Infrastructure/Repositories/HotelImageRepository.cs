using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using HotelAPI.Persistence.AppDbContext;

namespace HotelAPI.Infrastructure.Repositories
{
    public class HotelImageRepository : RepositoryBase<HotelImage>, IHotelImageRepository
    {
        public HotelImageRepository(HotelAppContext context) : base(context)
        {
        }
    }
}
