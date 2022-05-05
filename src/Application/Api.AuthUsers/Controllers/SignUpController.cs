using Domain.DTOs.AuthUsers.SignUp;
using Domain.Entities;
using Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;

namespace AuthUsers.Controllers
{

    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class SignUpController : ControllerBase
    {
        private IUserService _service;
        private ILogger<SignUpController> _logger;

        public SignUpController(IUserService service, ILogger<SignUpController> logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// Creates a User.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>A newly created User</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     {
        ///        "username": "william",
        ///        "email": "william@william.com",
        ///        "birthDate": "10/09/1991",
        ///        "cpf": "40953528847",
        ///        "phoneNumber": "11971816381",
        ///        "password": "123456"
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Post([FromBody] SignUpRequest user)
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
