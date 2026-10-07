using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BookmarksController : ControllerBase
    {
        // POST: api/Bookmarks
        [HttpPost]
        public IActionResult createBookmark()
        {
            return Ok(new
            {
                bookmarkId = Guid.NewGuid(),
                message = "Bookmark created successfully!"
            });
        }


        // GET: api/Bookmarks/{bookmarkId}
        [HttpGet("{bookmarkId}")]
        public IActionResult GetBookmarkById(Guid bookmarkId)
        {
            return Ok(new
            {
                bookmarkId = bookmarkId,
                message = "Bookmark details retrieved successfully!"
            });
        }


        // DELETE: api/Bookmarks/{bookmarkId}
        [HttpDelete("{bookmarkId}")]
        public IActionResult DeleteBookmark(Guid bookmarkId)
        {
            return Ok(new
            {
                bookmarkId = bookmarkId,
                message = "Bookmark deleted successfully!"
            });
        }

        public BookmarksController()
        {
        }
    }
}
