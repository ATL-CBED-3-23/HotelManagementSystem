using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using HotelAPI.Persistence.AppDbContext;

namespace HotelAPI.Infrastructure.Repositories
{
    public class ApplicationErrorRepository : RepositoryBase<ApplicationError> , IApplicationErrorRepository    
    {
        public ApplicationErrorRepository(HotelAppContext context) : base(context)
        {
        }
    }
}
