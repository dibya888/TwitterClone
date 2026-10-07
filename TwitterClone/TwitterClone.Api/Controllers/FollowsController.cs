using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FollowsController : ControllerBase
    {
        public FollowsController()
        {
        }


        // POST: api/Follows
        [HttpPost]
        public IActionResult FollowUser()
        {
            return Ok(new
            {
                followId = Guid.NewGuid(),
                message = "User followed successfully!"
            });
        }

        // DELETE: api/Follows/{followId}
        [HttpDelete("{followId}")]
        public IActionResult UnfollowUser(Guid followId)
        {
            return Ok(new
            {
                followId = followId,
                message = "User unfollowed successfully!"
            });
        }

        // GET: api/Follows/{followId}
        [HttpGet("{followId}")]
        public IActionResult GetFollowById(Guid followId)
        {
            return Ok(new
            {
                followId = followId,
                message = "Follow details retrieved successfully!"
            });
        }


        // GET: api/Follows
        [HttpGet]
        public IActionResult GetFollows()
        {
            var follows = new List<object>
            {
                new{ followId = Guid.NewGuid(), followedUserId = Guid.NewGuid() },
                new{ followId = Guid.NewGuid(), followedUserId = Guid.NewGuid() },
                new{ followId = Guid.NewGuid(), followedUserId = Guid.NewGuid() }
            };
            return Ok(follows);
        }


        // GET: api/Follows/Followers
        [HttpGet("followers")]
        public IActionResult GetFollowers()
        {
            var followers = new List<object>
            {
                new{ followerId = Guid.NewGuid(), followerUserId = Guid.NewGuid() },
                new{ followerId = Guid.NewGuid(), followerUserId = Guid.NewGuid() },
                new{ followerId = Guid.NewGuid(), followerUserId = Guid.NewGuid() }
            };
            return Ok(followers);
        }

        // GET: api/Follows/Following
        [HttpGet("following")]
        public IActionResult GetFollowing()
        {
            var following = new List<object>
            {
                new{ followingId = Guid.NewGuid(), followingUserId = Guid.NewGuid() },
                new{ followingId = Guid.NewGuid(), followingUserId = Guid.NewGuid() },
                new{ followingId = Guid.NewGuid(), followingUserId = Guid.NewGuid() }
            };
            return Ok(following);
        }
    }
}
