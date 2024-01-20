using AutoMapper;
using HotelAPI.Application.DTOs.HotelUserRoles;
using HotelAPI.Application.DTOs.HotelUsers;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace HotelAPI.Application.Services.Concrete
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<HotelUser> _userManager;
        private readonly RoleManager<HotelUserRole> _roleManager;
        private readonly IMapper _mapper;

        public AccountService(UserManager<HotelUser> userManager, IMapper mapper, RoleManager<HotelUserRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }

        public async Task<IdentityResult> RegisterUserAsync(UserAddRequest userAddRequest)
        {
            HotelUser user = _mapper.Map<HotelUser>(userAddRequest);
            IdentityResult result = await _userManager.CreateAsync(user, userAddRequest.Password);

            if (result.Succeeded)
            {
                foreach (var roleName in userAddRequest.Roles)
                {
                    var role = _mapper.Map<HotelUserRole>(roleName);
                    await _userManager.AddToRoleAsync(user, role.ToString());
                }

            }
            return result;
        }

        public async Task<IdentityResult> CreateRoleAsync(RoleAddRequest roleAddRequest)
        {
            HotelUserRole role = _mapper.Map<HotelUserRole>(roleAddRequest);
            IdentityResult result = await _roleManager.CreateAsync(role);
            return result;
        }

        public async Task<List<HotelUserRole>> GetAllRolesAsync()
        {
            List<HotelUserRole> roles = await _roleManager.Roles.Where(x => x.EntityStatus == EntityStatus.Active).ToListAsync();
            return roles;
        }
    }
}
