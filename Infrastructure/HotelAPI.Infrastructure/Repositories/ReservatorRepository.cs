using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using HotelAPI.Persistence.AppDbContext;

namespace HotelAPI.Infrastructure.Repositories
{
    public class ReservatorRepository : RepositoryBase<Reservator>, IReservatorRepository
    {
        public ReservatorRepository(HotelAppContext context) : base(context)
        {
        }
    }
}
