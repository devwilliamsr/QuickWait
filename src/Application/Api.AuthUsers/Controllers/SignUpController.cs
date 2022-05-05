using Domain.Entities;
using Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;

namespace AuthUsers.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SignUpController : ControllerBase
    {
        private IUserService _service;
        private ILogger<SignUpController> _logger;

        public SignUpController(IUserService service, ILogger<SignUpController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserEntity user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _service.Post(user);

                if (result != null)
                    return Created(new Uri(Url.Link("", new { id = result.Id })), result);
                else
                    return BadRequest();
            }
            catch (ArgumentException ex)
            {
                _logger.LogError($"ERRO: {ex}");
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
