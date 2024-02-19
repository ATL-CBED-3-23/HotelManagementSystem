using AutoMapper;
using HotelAPI.Application.DTOs.Reviews;
using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;

namespace HotelAPI.Application.Services.Concrete
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;

        public ReviewService(IReviewRepository reviewRepository, IMapper mapper)
        {
            _mapper = mapper;
            _reviewRepository = reviewRepository;
        }

        public async Task AddAsync(ReviewAddRequest ReviewAddRequest)
        {
            var map = _mapper.Map<Review>(ReviewAddRequest);

            await _reviewRepository.CreateAsync(map);
        }

        public async Task DeleteByIdAsync(int id)
        {
            Review Review = await _reviewRepository.FindByIdAsync(id);
            await _reviewRepository.DeActivate(Review);
        }

        public async Task EditAsync(ReviewUpdateRequest ReviewUpdateRequest)
        {
            var map = _mapper.Map<Review>(ReviewUpdateRequest);
            await _reviewRepository.UpdateAsync(map);
        }

        public async Task<ReviewTableResponse> GetById(int id)
        {
            Review review = await _reviewRepository.FindByIdAsync(id);
            ReviewTableResponse reviewTableResponse = _mapper.Map<ReviewTableResponse>(review); ;
            return reviewTableResponse;
        }

        public async Task<List<ReviewTableResponse>> GetTable()
        {
            var reviews = _reviewRepository.FindAllAsync();
            return _mapper.Map<List<ReviewTableResponse>>(reviews);
        }
    }
}
