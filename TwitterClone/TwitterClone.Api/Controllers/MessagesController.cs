using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MessagesController : ControllerBase
    {
        // POST: api/Messages
        [HttpPost]
        public IActionResult SendMessage()
        {
            return Ok(new
            {
                messageId = Guid.NewGuid(),
                message = "Message sent successfully!"
            });
        }


        // GET: api/Messages/{messageId}
        [HttpGet("{messageId}")]
        public IActionResult GetMessageById(Guid messageId)
        {
            return Ok(new
            {
                messageId = messageId,
                message = "Message details retrieved successfully!"
            });
        }

        // DELETE: api/Messages/{messageId}
        [HttpDelete("{messageId}")]
        public IActionResult DeleteMessage(Guid messageId)
        {
            return Ok(new
            {
                messageId = messageId,
                message = "Message deleted successfully!"
            });
        }

        public MessagesController()
        {
        }
    }
}
