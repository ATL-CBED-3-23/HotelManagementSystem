using AutoMapper;
using HotelAPI.Application.DTOs;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Application.Services.Concrete
{
    public class UserLoginHistoryService : IUserLoginHistoryService
    {
        private readonly IUserLoginHistoryRepository _userLoginHistoryRepository;
        private readonly IMapper _mapper;

        public UserLoginHistoryService(IUserLoginHistoryRepository userLoginHistoryRepository, IMapper mapper)
        {
            _userLoginHistoryRepository = userLoginHistoryRepository;
            _mapper = mapper;
        }

        public async Task AddAsync(UserLoginHistoryAddRequest userLoginHistoryAddRequest)
        {
            var map = _mapper.Map<UserLoginHistory>(userLoginHistoryAddRequest);
            await _userLoginHistoryRepository.CreateAsync(map);
        }

        public async Task<List<UserLoginHistory>> GetAllAsync()
        {
            var loginHistory =await _userLoginHistoryRepository.FindAllAsync();
            return loginHistory;
        }
    }
}
