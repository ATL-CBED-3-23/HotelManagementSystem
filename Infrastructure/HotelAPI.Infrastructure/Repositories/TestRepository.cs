using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using HotelAPI.Persistence.AppDbContext;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Infrastructure.Repositories
{
    public class TestRepository : RepositoryBase<TestError> , ITestRepository    
    {
        public TestRepository(HotelAppContext context) : base(context)
        {
        }
    }
}
