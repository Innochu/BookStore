using BookParadise.Application.Dtos;
using HeightsBookHub.Domain.Entities.SharedEntities;

namespace BookParadise.Application.Service.Interface
{
    public interface IAuthenticationService
    {
        Task<ApiResponse<RegResponseDto>> RegisterAsync(UserRegistrationDTO userRegistrationDTO);
    }
}
