using AutoMapper;
using HotelAPI.Application.DTOs.HotelUserRoles;
using HotelAPI.Application.DTOs.HotelUsers;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HotelAPI.Application.Services.Concrete //
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


        public async Task<UserDto> GetUserForUpdateById(int id)
        {
            HotelUser user = await _userManager.FindByIdAsync(id.ToString());

            UserDto userDto = _mapper.Map<UserDto>(user);
            userDto.Roles = _userManager.GetRolesAsync(user).Result;
            return userDto;
        }

        public async Task<IdentityResult> EditUserAsync(UserUpdateRequest userUpdateRequest)
        {
            HotelUser user = await _userManager.Users.SingleOrDefaultAsync(u => u.Id == userUpdateRequest.Id && u.EntityStatus == EntityStatus.Active);
            user.FirstName = userUpdateRequest.FirstName;
            user.LastName = userUpdateRequest.LastName;
            user.Email = userUpdateRequest.Email;
            user.UserName = userUpdateRequest.UserName;

            IdentityResult result = await _userManager.UpdateAsync(user);
            return result;
        }


        public async Task<IdentityResult> DeactivateUser(int id)
        {
            HotelUser user = await _userManager.Users.SingleOrDefaultAsync(u => u.Id == id && u.EntityStatus == EntityStatus.Active);
            user.EntityStatus = EntityStatus.InActive;
            IdentityResult result = await _userManager.UpdateAsync(user);

            return result;
        }

        public async Task<IdentityResult> ChangePasswordAsync(UserChangePasswordRequest userChangePasswordRequest)
        {
            HotelUser user = await _userManager.Users.SingleOrDefaultAsync(u => u.Id == userChangePasswordRequest.Id && u.EntityStatus == EntityStatus.Active);

            IdentityResult result = await _userManager.ChangePasswordAsync(user, userChangePasswordRequest.OldPassword, userChangePasswordRequest.NewPassword);
            return result;

        }

        public async Task<IdentityResult> ResetPasswordAsync(UserResetPasswordRequest userResetPasswordRequest)
        {
            HotelUser user = await _userManager.Users.SingleOrDefaultAsync(u => u.Id == userResetPasswordRequest.Id && u.EntityStatus == EntityStatus.Active);

            string resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            IdentityResult result = await _userManager.ResetPasswordAsync(user, resetToken, userResetPasswordRequest.NewPassword);
            return result;

        }

        public async Task<IdentityResult> CreateRoleAsync(RoleAddRequest roleAddRequest)
        {
            HotelUserRole role = _mapper.Map<HotelUserRole>(roleAddRequest);
            IdentityResult result = await _roleManager.CreateAsync(role);
            return result;
        }

        public async Task<IdentityResult> DeactivateRole(int id)
        {
            HotelUserRole role = await _roleManager.Roles.SingleOrDefaultAsync(r => r.Id == id && r.EntityStatus == EntityStatus.Active);
            role.EntityStatus = EntityStatus.InActive;
            IdentityResult result = await _roleManager.UpdateAsync(role);
            return result;
        }
        public List<RoleTableResponse> GetAllRoles()
        {
            var query = from o in _roleManager.Roles.Where(x => x.EntityStatus == EntityStatus.Active)

                        select new RoleTableResponse
                        {
                            Name = o.Name,
                            Id = o.Id,

                        };

            return query.ToList();

        }

        public List<UserTableResponse> GetAllUsers()
        {
            var query = from u in _userManager.Users.ToList()

                        select new UserTableResponse
                        {
                            Id = u.Id,
                            FullName = $"{u.FirstName} {u.LastName}",
                            Email = u.Email,
                            UserName = u.UserName,
                            Roles = _userManager.GetRolesAsync(u).Result

                        };

            return query.ToList();

        }

        public async Task<IdentityResult> AddUserToRoleAsync(int UserId, int RoleId)
        {
            IdentityResult result;
            HotelUser hotelUser = _userManager.Users.SingleOrDefault(u => u.Id == UserId && u.EntityStatus == EntityStatus.Active);
            HotelUserRole hotelUserRole = _roleManager.Roles.SingleOrDefault(r => r.Id == RoleId && r.EntityStatus == EntityStatus.Active);
            result = await _userManager.AddToRoleAsync(hotelUser, hotelUserRole.Name);
            return result;
        }

        public async Task<IdentityResult> AddUserToRolesAsync(int UserId, List<int> RoleIds)
        {
            IdentityResult result = null;
            HotelUser hotelUser = _userManager.Users.SingleOrDefault(u => u.Id == UserId && u.EntityStatus == EntityStatus.Active);
            IList<string> userRoles = await _userManager.GetRolesAsync(hotelUser);
            result = await _userManager.RemoveFromRolesAsync(hotelUser, userRoles);
            List<string> rolesByIds = _roleManager.Roles.Where(x => RoleIds.Contains(x.Id)).Select(n => n.Name).ToList();
            result = await _userManager.AddToRolesAsync(hotelUser, rolesByIds);
            return result;


        }

        public async Task<IdentityResult> RemoveUserFromRoleAsync(int UserId, int RoleId)
        {
            IdentityResult result;
            HotelUser hotelUser = _userManager.Users.SingleOrDefault(u => u.Id == UserId && u.EntityStatus == EntityStatus.Active);
            HotelUserRole hotelUserRole = _roleManager.Roles.SingleOrDefault(r => r.Id == RoleId && r.EntityStatus == EntityStatus.Active);
            result = await _userManager.RemoveFromRoleAsync(hotelUser, hotelUserRole.Name);
            return result;
        }

        public async Task<IdentityResult> Login(LoginRequest loginRequest)
        {
            var user = await _userManager.FindByNameAsync(loginRequest.UserName);
            if (user != null && await _userManager.CheckPasswordAsync(user, loginRequest.Password))
            {
                return IdentityResult.Success;
            }
            else
            {
                return IdentityResult.Failed(new IdentityError
                {
                    Description = "Invalid username or password."
                });
            }
        }
        public Task<IdentityResult> RemoveUserFromRolesAsync(int UserId, List<int> RoleId)
        {
            throw new NotImplementedException();
        }

        
    }
}
