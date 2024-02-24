using AutoMapper;
using HotelAPI.Application.DTOs;
using HotelAPI.Application.DTOs.HotelUserImages;
using HotelAPI.Application.DTOs.HotelUserRoles;
using HotelAPI.Application.DTOs.HotelUsers;
using HotelAPI.Application.Helpers;
using HotelAPI.Application.Identity;
using HotelAPI.Application.Identity.Concrete;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Data;
using System.Security.Claims;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using HotelAPI.Application.Utilities.Constants;

namespace HotelAPI.Application.Services.Concrete;

public class AccountService : IAccountService
{
    private readonly UserManager<HotelUser> _userManager;
    private readonly RoleManager<HotelUserRole> _roleManager;
    private readonly JWTOptions _jwtSettings;
    private readonly IJWTTokenService _jwtTokenService;
    private readonly IMapper _mapper;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ClaimsPrincipal _user;
    private readonly IUserLoginHistoryService _userLoginHistoryService;
    private readonly IHotelUserImageRepository _userImageRepository;
    public AccountService(UserManager<HotelUser> userManager, IMapper mapper, RoleManager<HotelUserRole> roleManager,
        IOptionsSnapshot<JWTOptions> jwtSettings, IJWTTokenService jwtTokenService, IHttpContextAccessor httpContextAccessor,
        IUserLoginHistoryService userLoginHistoryService, IHotelUserImageRepository hotelUserImageRepository)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _mapper = mapper;
        _jwtSettings = jwtSettings.Value;
        _jwtTokenService = jwtTokenService;
        _httpContextAccessor = httpContextAccessor;
        _user = _httpContextAccessor.HttpContext.User;
        _userLoginHistoryService = userLoginHistoryService;
        _userImageRepository = hotelUserImageRepository;

    }

    #region User
    public async Task<IdentityResult> RegisterUserAsync(UserAddRequest userAddRequest)
    {
        foreach (var image in userAddRequest.HotelUserImages)
        {
            byte[] bytes = Convert.FromBase64String(image.FileBase64);
            image.FileName = FileHelper.SavePhotoToFtp(bytes, image.FileName);
        }

        HotelUser user = _mapper.Map<HotelUser>(userAddRequest);
        IdentityResult result = await _userManager.CreateAsync(user, userAddRequest.Password);

        if (result.Succeeded)
        {
            foreach (var roleName in userAddRequest.Roles)
            {
                var role = _mapper.Map<HotelUserRole>(roleName);
                // await _userManager.AddToRolesAsync(user, userAddRequest.Roles.Select(x => x.Name).ToList());
            }

        }
        return result;
    }
    public async Task<UserToUpdateResponse> GetUserByIdAsync(int id)
    {
        List<HotelUser> users = _userManager.Users.ToList();
        List<HotelUserImage> images = await _userImageRepository.FindAllActiveAsync();

        var result = from user in users
                     join image in images on user.Id equals image.HotelUserId
                     where user.Id == id
                     select new UserToUpdateResponse
                     {
                         Id = user.Id,
                         FirstName = user.FirstName,
                         LastName = user.LastName,
                         Email = user.Email,
                         UserName = user.UserName,
                         NetworkStatus = user.NetworkStatus,
                         Roles = _userManager.GetRolesAsync(user).Result.ToList(),
                         HotelUserImage = new HotelUserImageTableResponse()
                         {
                             Id = user.HotelUserImage.Id,
                             FileName = user.HotelUserImage.FileName,
                             FileBase64 = Convert.ToBase64String(FileHelper.GetPhoto(image.FileName))
                         },

                     };

        return result.FirstOrDefault();
    }
    public async Task<IdentityResult> EditUserAsync(UserUpdateRequest userUpdateRequest)
    {
        foreach (var image in userUpdateRequest.HotelUserImages)
        {
            byte[] bytes = Convert.FromBase64String(image.FileBase64);
            image.FileName = FileHelper.SavePhotoToFtp(bytes, image.FileName);
        }
        HotelUser user = await _userManager.Users.SingleOrDefaultAsync(u => u.Id == userUpdateRequest.Id && u.EntityStatus == EntityStatus.Active);
        user.FirstName = userUpdateRequest.FirstName;
        user.LastName = userUpdateRequest.LastName;
        user.Email = userUpdateRequest.Email;
        user.UserName = userUpdateRequest.UserName;
        user.HotelUserImage = _mapper.Map<HotelUserImage>(userUpdateRequest.HotelUserImages);
        IdentityResult result = await _userManager.UpdateAsync(user);

        return result;
    }
    public async Task<IdentityResult> DeActivateUserAsync(int id)
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
    public async Task<IdentityResult> DeActivateRoleAsync(int id)
    {
        HotelUserRole role = await _roleManager.Roles.SingleOrDefaultAsync(r => r.Id == id && r.EntityStatus == EntityStatus.Active);
        role.EntityStatus = EntityStatus.InActive;
        IdentityResult result = await _roleManager.UpdateAsync(role);
        return result;
    }
    public List<RoleTableResponse> GetAllRolesAsync()
    {
        var query = from o in _roleManager.Roles.Where(x => x.EntityStatus == EntityStatus.Active)
                    select new RoleTableResponse
                    {
                        Name = o.Name,
                        Id = o.Id,
                    };
        return query.ToList();
    }
    public async Task<List<UserTableResponse>> GetAllUsersAsync()
    {
        List<HotelUser> users = _userManager.Users.ToList();
        List<HotelUserImage> images = await _userImageRepository.FindAllActiveAsync();
        var result = from user in users
                     join image in images on user.Id equals image.HotelUserId
                     select new UserTableResponse
                     {
                         Id = user.Id,
                         FullName = $"{user.FirstName} {user.LastName}",
                         Email = user.Email,
                         UserName = user.UserName,
                         NetworkStatus = user.NetworkStatus,
                         Roles = _userManager.GetRolesAsync(user).Result.ToList(),
                         HotelUserImage = new HotelUserImageTableResponse()
                         {
                             Id = user.HotelUserImage.Id,
                             FileName = user.HotelUserImage.FileName,
                             FileBase64 = Convert.ToBase64String(FileHelper.GetPhoto(image.FileName))
                         },

                     };

        return result.ToList();
    }
    public async Task<IdentityResult> AddUserToRoleAsync(int userId, int roleId)
    {
        IdentityResult result;
        HotelUser hotelUser = _userManager.Users.SingleOrDefault(u => u.Id == userId && u.EntityStatus == EntityStatus.Active);
        HotelUserRole hotelUserRole = _roleManager.Roles.SingleOrDefault(r => r.Id == roleId && r.EntityStatus == EntityStatus.Active);
        result = await _userManager.AddToRoleAsync(hotelUser, hotelUserRole.Name);
        return result;
    }
    public async Task<IdentityResult> AddUserToRolesAsync(int userId, List<int> roleIds)
    {
        IdentityResult result = null;
        HotelUser hotelUser = _userManager.Users.SingleOrDefault(u => u.Id == userId && u.EntityStatus == EntityStatus.Active);
        IList<string> userRoles = await _userManager.GetRolesAsync(hotelUser);
        result = await _userManager.RemoveFromRolesAsync(hotelUser, userRoles);
        List<string> rolesByIds = _roleManager.Roles.Where(x => roleIds.Contains(x.Id)).Select(n => n.Name).ToList();
        result = await _userManager.AddToRolesAsync(hotelUser, rolesByIds);
        return result;


    }
    public async Task<IdentityResult> RemoveUserFromRoleAsync(int userId, int roleId)
    {
        IdentityResult result;
        HotelUser hotelUser = _userManager.Users.SingleOrDefault(u => u.Id == userId && u.EntityStatus == EntityStatus.Active);
        HotelUserRole hotelUserRole = _roleManager.Roles.SingleOrDefault(r => r.Id == roleId && r.EntityStatus == EntityStatus.Active);
        result = await _userManager.RemoveFromRoleAsync(hotelUser, hotelUserRole.Name);
        return result;
    }
    public async Task<IdentityResult> RemoveUserFromRolesAsync(int userId, List<int> roleIds)
    {
        IdentityResult result;
        HotelUser hotelUser = _userManager.Users.SingleOrDefault(u => u.Id == userId && u.EntityStatus == EntityStatus.Active);
        IList<string> userRoles = await _userManager.GetRolesAsync(hotelUser);
        List<string> rolesByIds = _roleManager.Roles.Where(x => roleIds.Contains(x.Id)).Select(n => n.Name).ToList();
        result = await _userManager.RemoveFromRolesAsync(hotelUser, rolesByIds);
        return result;
    }
    #endregion

    #region Guest
    public async Task<IdentityResult> RegisterGuestUserAsync(GuestUserAddRequest guestUserAddRequest)
    {
        foreach (var image in guestUserAddRequest.HotelUserImages)
        {
            byte[] bytes = Convert.FromBase64String(image.FileBase64);
            image.FileName = FileHelper.SavePhotoToFtp(bytes, image.FileName);
        }
        HotelUser user = _mapper.Map<HotelUser>(guestUserAddRequest);
        IdentityResult result = await _userManager.CreateAsync(user, guestUserAddRequest.Password);

        if (result.Succeeded)
        {
            var role = _roleManager.Roles.Where(r => r.EntityStatus == EntityStatus.Active && r.Name == ApplicationRoles.User).Select(x => x.Name).ToList();
            await _userManager.AddToRolesAsync(user, role);

        }
        return result;
    }
    public async Task<GuestUserToUpdateResponse> GetGuestUserByIdAsync(int id)
    {
        List<HotelUser> users = _userManager.Users.ToList();
        List<HotelUserImage> images = await _userImageRepository.FindAllActiveAsync();

        var result = from user in users
                     join image in images on user.Id equals image.HotelUserId
                     where user.Id == id
                     select new GuestUserToUpdateResponse
                     {
                         Id = user.Id,
                         FirstName = user.FirstName,
                         LastName = user.LastName,
                         Email = user.Email,
                         UserName = user.UserName,
                         HotelUserImage = new HotelUserImageTableResponse()
                         {
                             Id = user.HotelUserImage.Id,
                             FileName = user.HotelUserImage.FileName,
                             FileBase64 = Convert.ToBase64String(FileHelper.GetPhoto(image.FileName))
                         },

                     };

        return result.FirstOrDefault();

    }
    public async Task<IdentityResult> EditGuestUserAsync(GuestUserUpdateRequest guestUserUpdateRequest)
    {

        byte[] bytes = Convert.FromBase64String(guestUserUpdateRequest.HotelUserImage.FileBase64);
        guestUserUpdateRequest.HotelUserImage.FileName = FileHelper.SavePhotoToFtp(bytes, guestUserUpdateRequest.HotelUserImage.FileName);

        HotelUser user = await _userManager.Users.SingleOrDefaultAsync(u => u.Id == guestUserUpdateRequest.Id && u.EntityStatus == EntityStatus.Active);
        user.FirstName = guestUserUpdateRequest.FirstName;
        user.LastName = guestUserUpdateRequest.LastName;
        user.Email = guestUserUpdateRequest.Email;
        user.UserName = guestUserUpdateRequest.UserName;
        user.HotelUserImage = _mapper.Map<HotelUserImage>(guestUserUpdateRequest.HotelUserImage);


        IdentityResult result = await _userManager.UpdateAsync(user);
        return result;
    }
    public async Task<IdentityResult> RemoveAccountAsync()
    {
        int userId = int.Parse(_user.FindFirstValue(ClaimTypes.NameIdentifier));
        HotelUser user = await _userManager.Users.SingleOrDefaultAsync(u => u.Id == userId && u.EntityStatus == EntityStatus.Active);
        user.SecurityStamp = "qwerty";
        user.EntityStatus = EntityStatus.InActive;
        IdentityResult result = await _userManager.UpdateAsync(user);

        return result;
    }
    #endregion


    public async Task<LoginedUserResponse> LoginAsync(LoginRequest loginRequest)
    {

        HotelUser user = await _userManager.Users.SingleOrDefaultAsync(x => x.UserName == loginRequest.UserName && x.EntityStatus == EntityStatus.Active);


        bool checkPassword = await _userManager.CheckPasswordAsync(user, loginRequest.Password);
        IList<string> roles = await _userManager.GetRolesAsync(user);

        UserClaimsOptions userModelForTokenGen = new UserClaimsOptions() { Id = user.Id, UserName = user.UserName };
        string jwt = _jwtTokenService.GenerateJwt(userModelForTokenGen, roles, _jwtSettings);

        LoginedUserResponse loginedUserResponse = new LoginedUserResponse()
        {
            UserFullName = $"{user.FirstName} {user.LastName}",
            UserName = user.UserName,
            UserRoles = roles,
            SecurityToken = jwt

        };

        await _userLoginHistoryService.AddAsync(new UserLoginHistoryAddRequest()
        {
            LoginDate = DateTime.Now,
            HotelUserId = user.Id,
        });

        user.NetworkStatus = NetworkStatus.Online;
        await _userManager.UpdateAsync(user);
        return loginedUserResponse;

    }



}
