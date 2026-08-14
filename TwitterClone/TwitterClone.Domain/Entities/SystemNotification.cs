using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class SystemNotification : Notification
    {
        public SystemNotification(Guid userId, string message) : base(userId, message, "System")
        {
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord} - Notification Type: {Type}, Message: {Message}, IsRead: {IsRead}, UserId: {UserId}";
        }
    }
}
