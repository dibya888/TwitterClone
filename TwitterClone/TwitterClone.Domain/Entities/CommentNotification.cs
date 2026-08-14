using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class CommentNotification : Notification
    {
        public CommentNotification(Guid commentedByUserId, string message) : base(commentedByUserId, message, "Comment")
        {

        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord} - Notification Type: {Type}, Message: {Message}, IsRead: {IsRead}, CommentedByUserId: {UserId}";
        }
    }
}
