using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class FriendRequestNotification : Notification
    {
        public FriendRequestNotification(Guid requestedByUserId) : base(requestedByUserId, "FriendRequest")
        {
        }

        public override string DescribeRecord()
        {
            return $"You Have Friend Request From: {UserId}";
        }

        public override string GetMessage()
        {
            return $"User {UserId} sent you a friend request.";
        }

    }
}
