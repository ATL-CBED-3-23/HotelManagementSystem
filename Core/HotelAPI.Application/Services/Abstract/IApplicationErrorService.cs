using HotelAPI.Domain.Entities;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IApplicationErrorService
    {
        Task<List<ApplicationError>> GetTable();
    }
}
