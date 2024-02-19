using HotelAPI.Application.Services.Abstract;
using HotelAPI.Domain.Entities;
using HotelAPI.Domain.Interfaces;

namespace HotelAPI.Application.Services.Concrete
{
    public class ApplicationErrorService : IApplicationErrorService
    {
        private readonly IApplicationErrorRepository _applicationErrorRepository;

        public ApplicationErrorService(IApplicationErrorRepository applicationErrorRepository)
        {
            _applicationErrorRepository = applicationErrorRepository;
        }

        public async Task<List<ApplicationError>> GetTable()
        {
            List<ApplicationError> applicationErrors = await _applicationErrorRepository.FindAllAsync();
            return applicationErrors;
        }
    }
}
