using _2FA_Zero.Classes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _2FA_Zero.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/v1/[controller]")]
    public class SessionController : ControllerBase
    {
        private readonly ILogger<SessionController> _logger;

        public SessionController(ILogger<SessionController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "AuthenticateUser/{id:guid}")]
        public async Task<Sessao> AuthenticateUser(Guid id)
        {
            return new Sessao();
        }
    }
}