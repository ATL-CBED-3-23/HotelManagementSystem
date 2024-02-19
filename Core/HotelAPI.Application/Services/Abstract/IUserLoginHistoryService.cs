using HotelAPI.Application.DTOs;
using HotelAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IUserLoginHistoryService
    {
        Task AddAsync(UserLoginHistoryAddRequest userLoginHistoryAddRequest);
        Task<List<UserLoginHistory>> GetAllAsync();
    }
}
