using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new List<User>
            {
                new User
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john@example.com"
                },
                new User
                {
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane@example.com"
                },
                new User
                {
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Email = "alice@example.com"
                }
            };

            return Ok(users);
        }
    }
}
