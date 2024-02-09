using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using HotelAPI.Persistence.AppDbContext;

namespace HotelAPI.Infrastructure.Repositories
{
    public class HotelUserImageRepository : RepositoryBase<HotelUserImage>, IHotelUserImageRepository
    {
        public HotelUserImageRepository(HotelAppContext context) : base(context)
        {
        }
    }
}
