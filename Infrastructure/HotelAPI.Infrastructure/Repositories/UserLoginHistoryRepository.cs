using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using HotelAPI.Persistence.AppDbContext;

namespace HotelAPI.Infrastructure.Repositories
{
    public class UserLoginHistoryRepository : RepositoryBase<UserLoginHistory>, IUserLoginHistoryRepository
    {
        public UserLoginHistoryRepository(HotelAppContext context) : base(context)
        {
        }
    }
}
