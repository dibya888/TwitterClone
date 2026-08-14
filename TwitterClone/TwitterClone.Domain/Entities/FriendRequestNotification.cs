using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class FriendRequestNotification : Notification
    {
        public FriendRequestNotification(Guid requestedByUserId, string message) : base(requestedByUserId, message, "FriendRequest")
        {
        }

        public string NotificationMessage()
        {
            return $"You Have Friend Request From: {UserId},{Message}";
        }
    }
}
