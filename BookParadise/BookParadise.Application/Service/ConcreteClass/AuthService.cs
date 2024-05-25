using BookParadise.Application.Dtos;
using BookParadise.Application.Service.Interface;
using BookParadise.Domain.Models;
using BookParadise.Domain.SharedEntity;
using BookParadise.Persistence.Repository.Interface;
using HeightsBookHub.Domain.Entities.SharedEntities;

using Microsoft.AspNetCore.Identity;

using Microsoft.Extensions.Configuration;

namespace BookParadise.Application.Service.ConcreteClass
{
    public class AuthService : IAuthService
    {
       
        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        IConfiguration _config;

        public AuthService(IConfiguration config, UserManager<User> userManager, IUnitOfWork unitOfWork, SignInManager<User> signInManager)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
            _userManager = userManager;
            _config = config;
        }

        public async Task<ApiResponse<RegResponseDto>> RegisterAsync(UserRegistrationDTO userRegistrationDTO)
        {

      
            var response = new ApiResponse<RegResponseDto>();
            try
            {
                var userfound = await _unitOfWork.AuthRepo.GetUserByEmail(userRegistrationDTO.Email);
                if (userfound != null)
                {
                    response.Message = "User email already exists";
                    response.Succeeded = false;
                    response.StatusCode = 400;
                }
                else
                {
                    var user = new User
                    {
                        FirstName = userRegistrationDTO.FirstName,
                        LastName = userRegistrationDTO.LastName,
                        Email = userRegistrationDTO.Email,
                        Gender = userRegistrationDTO.Gender,
                        PhoneNumber = userRegistrationDTO.PhoneNumber,
                        UserName = userRegistrationDTO.UserName
                    };

                    if (await _unitOfWork.AuthRepo.AddUser(user, userRegistrationDTO.Password))
                    {
                        var userReturnDto = new RegResponseDto
                        {
                            Id = user.Id,
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            Email = user.Email,
                            PhoneNumber = user.PhoneNumber,
                            UserName = user.UserName,
                            Gender = user.Gender
                        };
                        response = ApiResponse<RegResponseDto>.Success(userReturnDto, "User registered successfully", 200);
                    }
                }
                return response;
            }
            catch (Exception e)
            {
                response.Message = "Error: " + e;
                response.Succeeded = false;
                response.StatusCode = 500;
                return response;
            }
        }
    }
}
