using Microsoft.AspNetCore.Mvc;

namespace sistemaReservas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Users")]
        public User GetUsers()
        {
            return new User
            {
                Id = 1,
                Name = "Abigail Geovana",
                Email = "abigail@teste.com",
                Password = "12354789"
            };
        }
    }
}
