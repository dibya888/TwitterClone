using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class CommentNotification : Notification
    {
        public CommentNotification(Guid commentedByUserId) : base(commentedByUserId, "Comment")
        {

        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord} - Notification Type: {Type}, IsRead: {IsRead}, CommentedByUserId: {UserId}";
        }

        public override string GetMessage()
        {
            return $"User {UserId} commented on your tweet.";
        }
    }
}
