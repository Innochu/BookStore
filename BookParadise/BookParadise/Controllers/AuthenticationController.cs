using BookParadise.Application.Dtos;
using BookParadise.Application.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookParadise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IRabbitMQService _rabbitMQService;
        private readonly IConfiguration _configuration;

        public AuthenticationController(IAuthenticationService authenticationService,
                                        IRabbitMQService rabbitMQService, 
                                        IConfiguration configuration)
        {
            _authenticationService = authenticationService;
            _rabbitMQService = rabbitMQService;
            _configuration = configuration;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAsync(UserRegistrationDTO userRegistrationDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //string queueName = _configuration.GetValue<string>("TopicAndQueueNames:RegisterUserQueue");
            //_rabbitMQService.SendMessage(userRegistrationDTO.Email, queueName);
            return Ok(await _authenticationService.RegisterAsync(userRegistrationDTO));
        }
    }
}
