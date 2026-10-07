using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NotificationsController : ControllerBase
    {
        public NotificationsController()
        {
        }


        // GET: api/Notifications
        [HttpGet]
        public IActionResult GetNotifications()
        {
            var notifications = new List<object>
            {
                new{ notificationId = Guid.NewGuid(), message = "You have a new follower!" },
                new{ notificationId = Guid.NewGuid(), message = "Your tweet has been liked!" },
                new{ notificationId = Guid.NewGuid(), message = "You have a new mention!" }
            };
            return Ok(notifications);
        }


        // POST: api/Notifications
        [HttpPost]
        public IActionResult CreateNotification()
        {
            return Ok(new
            {
                notificationId = Guid.NewGuid(),
                message = "New notification created successfully!"
            });
        }


        // DELETE: api/Notifications/{notificationId}
        [HttpDelete("{notificationId}")]
        public IActionResult DeleteNotification([FromRoute] Guid notificationId)
        {
            return Ok(new
            {
                notificationId = notificationId,
                message = "Notification deleted successfully!"
            });
        }


        // GET: api/Notifications/{notificationId}
        [HttpGet("{notificationId}")]
        public IActionResult GetNotificationById(Guid notificationId)
        {
            return Ok(new
            {
                notificationId = notificationId,
                message = "Notification details retrieved successfully!"
            });
        }


        // GET: api/Notifications/user/{userId}
        [HttpGet("user/{userId}")]
        public IActionResult GetNotificationByUserId(Guid userId)
        {
            return Ok(new
            {
                userId = userId,
                message = "Notifications for the user retrieved successfully!"
            });
        }


        // PUT: api/Notifications/{notificationId}
        [HttpPut("{notificationId}")]
        public IActionResult UpdateNotification(Guid notificationId)
        {
            return Ok(new
            {
                notificationId = notificationId,
                message = "Notification updated successfully!"
            });
        }


        // PATCH: api/Notifications/{notificationId}/read
        [HttpPatch("{notificationId}/read")]
        public IActionResult MarkAsRead(Guid notificationId)
        {
            return Ok(new
            {
                notificationId = notificationId,
                message = "Notification marked as read successfully!"
            });
        }
    }
}
