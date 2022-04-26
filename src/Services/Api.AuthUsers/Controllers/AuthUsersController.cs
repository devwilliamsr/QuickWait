using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.AuthUsers.Controllers
{
    public class AuthUsersController : ControllerBase
    {
        private readonly ILogger<AuthUsersController> _logger;  
        public AuthUsersController(ILogger<AuthUsersController> logger)
        {
            _logger = logger;
        }

    }
}