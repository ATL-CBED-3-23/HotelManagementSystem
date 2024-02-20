using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using HotelAPI.Persistence.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Infrastructure.Repositories
{
    public class HotelRatingRepository : RepositoryBase<HotelRating>, IHotelRatingRepository
    {
        public HotelRatingRepository(HotelAppContext context) : base(context)
        {
        }
    }
}
