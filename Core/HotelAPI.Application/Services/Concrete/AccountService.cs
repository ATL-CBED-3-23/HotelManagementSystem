using AutoMapper;
using HotelAPI.Application.DTOs.HotelUsers;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace HotelAPI.Application.Services.Concrete
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<HotelUser> _userManager;
        private readonly IMapper _mapper;

        public AccountService(UserManager<HotelUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task RegisterUserAsync(UserAddRequest userAddRequest)
        {
            HotelUser hotelUser = _mapper.Map<HotelUser>(userAddRequest);
            await _userManager.CreateAsync(hotelUser);
        }
    }
}
