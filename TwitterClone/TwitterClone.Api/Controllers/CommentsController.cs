using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CommentsController : ControllerBase
    {
        public CommentsController()
        {
        }


        // POST: api/Comments
        [HttpPost]
        public IActionResult CreateComment()
        {
            return Ok(new
            {
                commentId = Guid.NewGuid(),
                message = "Comment created successfully!"
            });
        }


        // GET: api/Comments/{commentId}
        [HttpGet("{commentId}")]
        public IActionResult GetCommentById(Guid commentId)
        {
            return Ok(new
            {
                commentId = commentId,
                message = "Comment details retrieved successfully!"
            });
        }


        // DELETE: api/Comments/{commentId}
        [HttpDelete("{commentId}")]
        public IActionResult DeleteComment(Guid commentId)
        {
            return Ok(new
            {
                commentId = commentId,
                message = "Comment deleted successfully!"
            });
        }

        // GET: api/Comments
        [HttpGet]
        public IActionResult GetComments()
        {
            var comments = new List<object>
            {
                new{ commentId = Guid.NewGuid(), content = "This is a comment." },
                new{ commentId = Guid.NewGuid(), content = "This is another comment." },
                new{ commentId = Guid.NewGuid(), content = "Yet another comment." }
            };
            return Ok(comments);
        }


    }
}
