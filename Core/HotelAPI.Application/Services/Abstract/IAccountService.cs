using HotelAPI.Application.DTOs.HotelUsers;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IAccountService
    {
        Task RegisterUserAsync(UserAddRequest userAddRequest);
    }
}
