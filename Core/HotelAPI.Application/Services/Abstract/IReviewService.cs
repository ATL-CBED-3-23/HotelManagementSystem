﻿using HotelAPI.Application.DTOs.Reviews;

namespace HotelAPI.Application.Services.Abstract
{
    public interface IReviewService
    {
        Task AddAsync(ReviewAddRequest reviewAddRequest);
        Task EditAsync(ReviewUpdateRequest reviewUpdateRequest);
        Task<ReviewUpdateRequest> GetForUpdateById(int id);
        Task<List<ReviewTableResponse>> GetTable();
        Task DeleteByIdAsync(int id);
    }
}
