using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LikesController : ControllerBase
    {
        public LikesController()
        {
        }

        // POST: api/Likes
        [HttpPost]
        public IActionResult LikePost()
        {
            return Ok(new
            {
                likeId = Guid.NewGuid(),
                message = "Post liked successfully!"
            });
        }


        // GET: api/Likes/{likeId}
        [HttpGet("{likeId}")]
        public IActionResult GetLikeById(Guid likeId)
        {
            return Ok(new
            {
                likeId = likeId,
                message = "Like details retrieved successfully!"
            });
        }


        // DELETE: api/Likes/{likeId}
        [HttpDelete("{likeId}")]
        public IActionResult UnlikePost(Guid likeId)
        {
            return Ok(new
            {
                likeId = likeId,
                message = "Post unliked successfully!"
            });
        }

        // GET: api/Likes
        [HttpGet]
        public IActionResult GetLikes()
        {
            var likes = new List<object>
            {
                new{ likeId = Guid.NewGuid(), likedPostId = Guid.NewGuid() },
                new{ likeId = Guid.NewGuid(), likedPostId = Guid.NewGuid() },
                new{ likeId = Guid.NewGuid(), likedPostId = Guid.NewGuid() }
            };
            return Ok(likes);
        }



        // GET: api/Likes/User/{userId}
        [HttpGet("user/{userId}")]
        public IActionResult GetLikesByUserId(Guid userId)
        {
            var likes = new List<object>
            {
                new{ likeId = Guid.NewGuid(), likedPostId = Guid.NewGuid(), userId = userId },
                new{ likeId = Guid.NewGuid(), likedPostId = Guid.NewGuid(), userId = userId },
                new{ likeId = Guid.NewGuid(), likedPostId = Guid.NewGuid(), userId = userId }
            };
            return Ok(likes);
        }


        // GET: api/Likes/Post/{postId}
        [HttpGet("post/{postId}")]
        public IActionResult GetLikesByPostId(Guid postId)
        {
            var likes = new List<object>
            {
                new{ likeId = Guid.NewGuid(), likedPostId = postId, userId = Guid.NewGuid() },
                new{ likeId = Guid.NewGuid(), likedPostId = postId, userId = Guid.NewGuid() },
                new{ likeId = Guid.NewGuid(), likedPostId = postId, userId = Guid.NewGuid() }
            };
            return Ok(likes);
        }
    }
}
