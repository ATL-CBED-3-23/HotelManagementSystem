using HotelAPI.Application.DTOs.Reviews;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IReviewService
    {
        Task AddAsync(ReviewAddRequest reviewAddRequest);
        Task EditAsync(ReviewUpdateRequest reviewUpdateRequest);
        Task<ReviewTableResponse> GetByIdAsync(int id);
        Task<List<ReviewTableResponse>> GetTableAsync();
        Task DeleteByIdAsync(int id);
    }
}
