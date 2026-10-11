using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {

        public UsersController()
        {
        }


        // GET: api/Users
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


        // POST: api/Users
        [HttpPost]
        [AllowAnonymous]
        public IActionResult CreateUser()
        {
            return Ok(new
            {
                FirstName = "New",
                LastName = "User",
                Email = "newuser@example.com"
            });
        }


        // GET: api/Users/{id}
        [HttpGet("{id}")]
        public IActionResult GetUserById([FromRoute] Guid id)
        {
            return Ok(new
            {
                UserId = id,
                Username = "user1" + id.ToString()
            });
        }



        // PUT: api/Users/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromRoute] Guid id)
        {
            return Ok(new
            {
                UserId = id,
                Username = "updateUser" + id.ToString()
            });
        }


        // I want update only user phone number
        // PATCH: api/Users/{id}/phone
        public IActionResult UpdateUserPhoneNumber([FromRoute] Guid id, [FromBody] string phoneNumber)
        {
            return Ok(new
            {
                UserId = id,
                PhoneNumber = phoneNumber
            });
        }

        // DELETE: api/Users/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser([FromRoute] Guid id)
        {
            return Ok(new
            {
                UserId = id,
                Message = "User deleted successfully"
            });
        }
    }
}
